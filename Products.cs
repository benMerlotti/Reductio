public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool Available { get; set; }
    public int ProductType { get; set; }


};

public class ProductTypeId
{
    public int Id { get; set; }
    public string Name { get; set; }
}