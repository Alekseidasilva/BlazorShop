namespace BlazorShop.Models;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }


    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}