using System.ComponentModel.DataAnnotations;
using FrituurTWiel.Shared.Contracts.Enums;
using Microsoft.EntityFrameworkCore;


namespace FrituurTWiel.Products.Persistence.DataModel.Entities;

public class ProductEntity
{
    public int Id { get; set; }
    [MaxLength(50)]
    public required string Name { get; set; }
    [MaxLength(250)]
    public required string Description { get; set; }
    [Precision(8, 2)]
    public required decimal Price { get; set; }
    public required bool Available { get; set; }
    public required Category Category { get; set; }
}