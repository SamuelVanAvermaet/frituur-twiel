using FrituurTWiel.Shared.Contracts.Enums;

namespace FrituurTWiel.Products.Domain.Model;

public class ProductModel
{
    public int? ProductId { get; set; }

    public required string Name { get; set; }

    public required string? Description { get; set; }

    public required decimal Price { get; set; }
    public required Category Category { get; set; }
    public required bool Available { get; set; }

}