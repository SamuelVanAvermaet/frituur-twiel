using FrituurTWiel.Products.Domain.Model;
using FrituurTWiel.Products.Persistence.DataModel;
using FrituurTWiel.Products.Persistence.DataModel.Entities;
using FrituurTWiel.Products.Persistence.Exceptions;
using FrituurTWiel.Products.Persistence.Interfaces;
using FrituurTWiel.Products.Persistence.Mapping;
using FrituurTWiel.Shared.Contracts.Enums;

using Microsoft.EntityFrameworkCore;

namespace FrituurTWiel.Products.Persistence;

public class ProductRepository(FrituurTWielDbContext dbContext) : IProductRepository
{
    public async Task<ProductModel> CreateProduct(ProductModel productModelToCreate)
    {
        var entity = productModelToCreate.AsEntity();
        dbContext.Products.Add(entity);
        await dbContext.SaveChangesAsync();
        return entity.AsModel();
    }

    public async Task DeleteProduct(int id)
    {
        var productToDelete = await dbContext.Products.FindAsync(id);

        if (productToDelete is null)
            throw new ProductEntityNotFoundException();
        
        dbContext.Products.Remove(productToDelete);
        await dbContext.SaveChangesAsync();
    }

    public async Task<List<ProductModel>> GetAllProducts(Category? category = null)
    {
        IQueryable<ProductEntity> query = dbContext.Products;

    if (category.HasValue)
    {
        query = query.Where(p => p.Category == category.Value);
    }

    return await query
        .Select(p => p.AsModel())
        .ToListAsync();
    }

    public async Task<ProductModel?> GetProductById(int id)
    {
        var productEntity = await dbContext.Products.FindAsync(id);
        return productEntity?.AsModel();
    }

    public async Task<List<ProductModel>> GetProductsByIds(int[] ids)
    {
        var productEntities = await dbContext.Products.Where(p => ids.Contains((int)p.Id)).ToListAsync();
        return productEntities.Select(e => e.AsModel()).ToList();
    }

    public async Task UpdateProduct(ProductModel productModelToUpdate)
    {
        var entity = productModelToUpdate.AsEntity();
        dbContext.Products.Update(entity);
        await dbContext.SaveChangesAsync();
    }
}