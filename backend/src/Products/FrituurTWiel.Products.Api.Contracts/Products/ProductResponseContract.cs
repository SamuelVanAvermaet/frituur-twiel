using System;
using FrituurTWiel.Shared.Contracts.Enums;

namespace FrituurTWiel.Products.Api.Contracts.Products;

public class ProductResponseContract
{
    public int ProductId { get; set; }

    public required string Name { get; set; }

    public string? Description { get; set; }

    public required decimal Price { get; set; }
    public required Category Category { get; set; }
    public bool Available { get; set; }
}