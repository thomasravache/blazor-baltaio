namespace BlazingShop.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public double Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; } = new();
}