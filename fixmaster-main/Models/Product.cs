namespace fixmaster.Models;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public int Price { get; set; }
    public required string Image { get; set; }
    public int Stock { get; set; }

}