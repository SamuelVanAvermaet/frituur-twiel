using FrituurTWiel.Products.Api.Contracts.Products;
using FrituurTWiel.Shared.Contracts.Enums;

namespace FrituurTWiel.Products.Domain.Services.Interfaces;

public interface IProductService
{
    Task<ProductResponseContract> CreateProduct(ProductRequestContract ProductToCreate);
    Task<ProductResponseContract?> GetProductById(int id);
    Task<IEnumerable<ProductResponseContract>> GetAllProducts(Category? category = null);
    Task UpdateProduct(int productId, ProductRequestContract ProductToUpdate);
    Task DeleteProduct(int id);

}