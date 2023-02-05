using DevReviews.Application.Models;
using DevReviews.Application.Services.Interfaces;
using DevReviews.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevReviews.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var model = await _productService.GetProductsAsync();

            if(model == null)
                return NotFound("Products not found");

            return Ok(model);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var model = await _productService.GetProductDetailsByIdAsync(id);

            if(model == null)
                return NotFound("Products not found");
            //se não achar, retornar NotFound()

            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddProductInputModel model)
        {
           if (model == null)
                return BadRequest("Data Invalid");           

            await _productService.AddProductAsync(model);

            return CreatedAtAction(nameof(GetById), new { id =model.Id}, model);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UpdateProductInputModel model)
        {
            //var product = await _productService.GetProductByIdAsync(id);

            //if (product == null)
            //    return NotFound();

            await _productService.UpdateProductAsync(model);

            return NoContent();
        }


    }
}
