using FrituurTWiel.Products.Api.Contracts.Products;
using FrituurTWiel.Products.Domain.Model;

namespace FrituurTWiel.Products.Domain.Services.Mapping;
public static class ProductMappingExtension
{
    public static ProductModel AsModel(this ProductRequestContract contract, int? id = null)
    {
        return new ProductModel
        {
            ProductId = id,
            Name = contract.Name,
            Description = contract.Description,
            Price = contract.Price,
            Category = contract.Category,   
            Available = contract.Available,
        };
    }

    public static ProductResponseContract AsContract(this ProductModel model)
    {
        if (model.ProductId is null)
            throw new InvalidOperationException("Cannot map model to contract without ProductId");
        
        return new ProductResponseContract
        {
            ProductId = model.ProductId.Value,
            Name = model.Name,
            Description = model.Description,
            Price = model.Price,
            Category = model.Category,
            Available = model.Available,
        };
    }
}