using System.ComponentModel.DataAnnotations;
using FrituurTWiel.Shared.Contracts.Enums;

namespace FrituurTWiel.Products.Api.Contracts.Products;

public class ProductRequestContract
{
    public required string Name { get; set; }

    [RegularExpression(@"^\d+([.,]\d{1,2})?$", ErrorMessage = "The price may have a maximum of 2 decimal places.")]
    public required decimal Price { get; set; }
    public required Category Category { get; set; }

    [MaxLength(255, ErrorMessage = "The description may contain a maximum of 255 characters.")]
    public string? Description { get; set; }
     public bool Available { get; set; } = true;

}