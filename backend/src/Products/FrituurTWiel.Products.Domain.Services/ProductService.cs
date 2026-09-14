
using FrituurTWiel.Products.Api.Contracts.Products;
using FrituurTWiel.Products.Domain.Model.Exceptions;
using FrituurTWiel.Products.Domain.Services.Interfaces;
using FrituurTWiel.Products.Domain.Services.Mapping;
using FrituurTWiel.Products.Persistence.Exceptions;
using FrituurTWiel.Products.Persistence.Interfaces;
using FrituurTWiel.Shared.Contracts.Enums;


namespace FrituurTwiel.Products.Domain.Services;

public class ProductService(IProductRepository productRepository) : IProductService
{
    public async Task<ProductResponseContract> CreateProduct(ProductRequestContract productToCreate)
    {
        var model = productToCreate.AsModel();
        var created = await productRepository.CreateProduct(model);
        var contract = created.AsContract();
        return contract;
    }

    public async Task DeleteProduct(int id)
    {
         try
        {
            await productRepository.DeleteProduct(id);
        }
        catch (ProductEntityNotFoundException)
        {
            throw new ProductNotFoundException(id);
        }
    }

    public async Task<IEnumerable<ProductResponseContract>> GetAllProducts(Category? category = null)
    {
        var products = await productRepository.GetAllProducts(category);
        return products.Select(c => c.AsContract());
    }

    public async Task<ProductResponseContract?> GetProductById(int id)
    {
        var product = await productRepository.GetProductById(id);
        return product?.AsContract();
    }

    public async Task UpdateProduct(int productId, ProductRequestContract productToUpdate)
    {
        var model = productToUpdate.AsModel(productId);
        await productRepository.UpdateProduct(model);
    }
}