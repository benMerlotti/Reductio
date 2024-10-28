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

Console.WriteLine("Welcome to Red and Abe's Magic Shop");