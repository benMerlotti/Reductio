public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool Available { get; set; }
    public int ProductType { get; set; }
    public DateTime DateStocked { get; set; }
    public int DaysOnShelf
    {
        get
        {
            TimeSpan timeOnShelf = DateTime.Now - DateStocked;
            return timeOnShelf.Days;
        }
    }


};

public class ProductTypeId
{
    public int Id { get; set; }
    public string Name { get; set; }
}