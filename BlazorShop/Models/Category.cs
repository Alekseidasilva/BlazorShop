using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "informe o Titulo")]
    [MinLength(3, ErrorMessage = "A categoria deve ter no minimo 3 caracteres")]
    [MaxLength(150, ErrorMessage = "A categoria deve ter no maximo 60 caracteres")]
    public string Title { get; set; } = string.Empty;
}