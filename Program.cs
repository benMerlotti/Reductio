// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<Product> products = new List<Product>()
{
    // Apparel
    new Product() { Name = "Wizard Hat", Price = 15.99m, Available = true, ProductType = 1 },
    new Product() { Name = "Enchanted Robe", Price = 30.50m, Available = true, ProductType = 1 },
    new Product() { Name = "Magic Boots", Price = 25.00m, Available = false, ProductType = 1 },
    new Product() { Name = "Sorcerer's Gloves", Price = 12.75m, Available = true, ProductType = 1 },
    new Product() { Name = "Mystic Belt", Price = 10.99m, Available = true, ProductType = 1 },

    // Potions
    new Product() { Name = "Healing Potion", Price = 5.50m, Available = true, ProductType = 2 },
    new Product() { Name = "Mana Elixir", Price = 8.00m, Available = true, ProductType = 2 },
    new Product() { Name = "Invisibility Potion", Price = 20.00m, Available = false, ProductType = 2 },
    new Product() { Name = "Strength Serum", Price = 12.99m, Available = true, ProductType = 2 },
    new Product() { Name = "Fire Resistance Potion", Price = 15.00m, Available = false, ProductType = 2 },

    // Enchanted Objects
    new Product() { Name = "Invisibility Cloak", Price = 250.00m, Available = false, ProductType = 3 },
    new Product() { Name = "Flying Broomstick", Price = 75.00m, Available = true, ProductType = 3 },
    new Product() { Name = "Magic Mirror", Price = 100.00m, Available = true, ProductType = 3 },
    new Product() { Name = "Teleportation Stone", Price = 150.50m, Available = false, ProductType = 3 },
    new Product() { Name = "Crystal Ball", Price = 60.00m, Available = true, ProductType = 3 },

    // Wands
    new Product() { Name = "Phoenix Feather Wand", Price = 75.00m, Available = true, ProductType = 4 },
    new Product() { Name = "Dragon Heartstring Wand", Price = 85.00m, Available = false, ProductType = 4 },
    new Product() { Name = "Elder Wand", Price = 300.00m, Available = false, ProductType = 4 },
    new Product() { Name = "Unicorn Hair Wand", Price = 70.00m, Available = true, ProductType = 4 },
    new Product() { Name = "Ash Wood Wand", Price = 45.00m, Available = true, ProductType = 4 }
};

List<ProductTypeId> productTypes = new List<ProductTypeId>()
{
    new ProductTypeId { Id = 1, Name = "Apparel" },
    new ProductTypeId { Id = 2, Name = "Potions" },
    new ProductTypeId { Id = 3, Name = "Enchanted Objects" },
    new ProductTypeId { Id = 4, Name = "Wands" }
};

string input = null;
while (input != "z")

{
    Console.Clear();
    Console.WriteLine("Welcome to Red and Abe's Magic Shop");
    Console.WriteLine(@"a. View all products
b. Add a product
c. Delete a product
d. Update a product
e. Search by product type
z. Exit");

    Console.WriteLine("Choose an option to continue:");
    input = Console.ReadLine();

    if (input == "a")
    {
        ViewProducts();
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }
    else if (input == "b")
    {
        AddProduct();
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }
    else if (input == "c")
    {
        DeleteProduct();
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }
    else if (input == "d")
    {
        UpdateProduct();
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }
    else if (input == "e")
    {
        SearchByType();
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }
}

void ViewProducts()
{
    foreach (Product product in products)
    {
        Console.WriteLine(product.Name);
    }
}

void AddProduct()
{


    Console.WriteLine("To add a product fill out the form below:");

    Console.WriteLine("Name:");
    string name = Console.ReadLine();

    Console.WriteLine("Price:");
    decimal price = decimal.Parse(Console.ReadLine());

    Console.WriteLine(@"Type:
    1. Apparel
    2. Potion
    3. Enchanted Object
    4. Wand");
    int type = int.Parse(Console.ReadLine().Trim());

    Product newProduct = new Product()
    {
        Name = name,
        Price = price,
        Available = true,
        ProductType = type
    };

    products.Add(newProduct);

    Console.WriteLine("Product added successfully!");
}

void DeleteProduct()
{
    int index = 1;
    Console.WriteLine("Choose a product to delete:");

    foreach (Product product in products)
    {
        Console.WriteLine($"{index}. {product.Name}");
        index++;
    }

    Console.WriteLine("Enter the number of the product to delete:");
    int deletedProductId = int.Parse(Console.ReadLine());

    products.Remove(products[deletedProductId - 1]);
}

void UpdateProduct()
{
    int index = 1;
    Console.WriteLine("Choose a product to update:");

    foreach (Product product in products)
    {
        Console.WriteLine($"{index}. {product.Name}");
        index++;
    }

    Console.WriteLine("Enter the number of the product to update:");
    int chosenProductId = int.Parse(Console.ReadLine());

    Product chosenProduct = products[chosenProductId - 1];

    // Prompt for new values and update each property
    Console.Write("Enter new name (leave blank to keep current): ");
    string newName = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(newName))
    {
        chosenProduct.Name = newName;
    }

    Console.Write("Enter new price (leave blank to keep current): ");
    string newPrice = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(newPrice))
    {
        chosenProduct.Price = decimal.Parse(newPrice);
    }

    Console.Write("Is the product available (true/false): ");
    string newAvailable = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(newAvailable))
    {
        chosenProduct.Available = bool.Parse(newAvailable);
    }

    Console.WriteLine(@"Select new type:
    1. Apparel
    2. Potion
    3. Enchanted Object
    4. Wand
    (Leave blank to keep current)");
    string newType = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(newType))
    {
        chosenProduct.ProductType = int.Parse(newType);
    }

    Console.WriteLine("Product updated successfully.");

}

void SearchByType()
{
    Console.WriteLine("Choose a product type to show inventory for that type:");
    int index = 1;
    foreach (ProductTypeId type in productTypes)
    {
        Console.WriteLine($"{index}. {type.Name}");
        index++;
    }

    int chosenType = int.Parse(Console.ReadLine());

    foreach (Product product in products)
    {
        if (chosenType == product.ProductType)
        {
            Console.WriteLine(product.Name);
        }
    }
}