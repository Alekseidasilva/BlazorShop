using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Informe o Titulo")]
    [MinLength(3, ErrorMessage = "O Produto deve ter no minimo 3 caracteres")]
    [MaxLength(150, ErrorMessage = "o Produto deve ter no maximo 60 caracteres")]
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    [Required(ErrorMessage = "Infome o preço do Produto")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }


    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}