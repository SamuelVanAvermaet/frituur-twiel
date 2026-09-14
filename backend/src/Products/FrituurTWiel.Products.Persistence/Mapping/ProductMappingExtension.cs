using System;
using FrituurTWiel.Products.Domain.Model;
using FrituurTWiel.Products.Persistence.DataModel.Entities;

namespace FrituurTWiel.Products.Persistence.Mapping;

public static class ProductMappingExtension
{
    
    public static ProductEntity AsEntity(this ProductModel model)
    {
        return new ProductEntity
        {
            Id = model.ProductId ?? 0,
            Description = model.Description ?? string.Empty,
            Price = model.Price,
            Name = model.Name,
            Available = model.Available,
            Category = model.Category
        };
    }
    
    public static ProductModel AsModel(this ProductEntity entity)
    {
        return new ProductModel()
        {
            ProductId = entity.Id,
            Description = entity.Description,
            Price = entity.Price,
            Name = entity.Name,
            Available = entity.Available,
            Category = entity.Category
        };
    }
}