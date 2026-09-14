using FrituurTWiel.Products.Api.Contracts.Products;
using FrituurTWiel.Products.Domain.Model.Exceptions;
using FrituurTWiel.Products.Domain.Services.Interfaces;
using FrituurTWiel.Shared.Contracts.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrituurTWiel.Products.Api.Controllers
{
     [Route("api/products")]
    [Authorize]
    [ApiController]
    public class ProductController(IProductService productService) : ControllerBase
    {   
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductResponseContract>>> GetAllProducts([FromQuery] Category? category)
        {   
            if(category.HasValue)
            {
                var filteredProducts = (await productService.GetAllProducts()).Where(p => p.Category == category.Value);
                return Ok(filteredProducts);
            }

            var products = await productService.GetAllProducts();
            return Ok(products);
        }
        [AllowAnonymous]
        [HttpGet("{id}")]
                public async Task<ActionResult<ProductResponseContract>> GetProductById(int id)
        {
            var product = await productService.GetProductById(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

       

        [HttpPost]
        
        public async Task<ActionResult<ProductResponseContract>> CreateProduct([FromBody] ProductRequestContract productToCreate)
        {
            var created = await productService.CreateProduct(productToCreate);
            return CreatedAtAction(nameof(GetProductById), new { id = created.ProductId }, created);
        }

        [HttpPut("{id}")]
        
        public async Task<IActionResult> UpdateProduct([FromRoute] int id, [FromBody] ProductRequestContract productToUpdate)
        {
            try
            {
                await productService.UpdateProduct(id, productToUpdate);
                return NoContent();
            }
            catch (ProductNotFoundException)
            {
                return NotFound(new ProblemDetails
                {
                    Title = "Product Not Found",
                    Detail = $"No product found with ID {id}."
                });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            try
            {
                await productService.DeleteProduct(id);
                return NoContent();
            }
            catch (ProductNotFoundException)
            {
                return NotFound(new ProblemDetails
                {
                    Title = "Product Not Found",
                    Detail = $"No product found with ID {id}."           
                });
            }
        }
    }
}
