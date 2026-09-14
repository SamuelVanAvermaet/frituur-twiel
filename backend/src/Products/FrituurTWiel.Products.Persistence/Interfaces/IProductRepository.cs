using FrituurTWiel.Products.Domain.Model;
using FrituurTWiel.Shared.Contracts.Enums;

namespace FrituurTWiel.Products.Persistence.Interfaces;

public interface IProductRepository
{
    Task<ProductModel> CreateProduct(ProductModel productModelToCreate);
    Task<ProductModel?> GetProductById(int id);
    Task<List<ProductModel>> GetProductsByIds(int[] ids);
    Task<List<ProductModel>> GetAllProducts(Category? category = null);
    Task UpdateProduct(ProductModel productModelToUpdate);
    Task DeleteProduct(int id);
}