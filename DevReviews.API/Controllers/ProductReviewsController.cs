using DevReviews.Application.Models;
using DevReviews.Application.Services.Implementations;
using DevReviews.Application.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevReviews.API.Controllers
{
    [Route("api/products/{productId}/productreviews")]
    [ApiController]
    public class ProductReviewsController : ControllerBase
    {
        private readonly IProductReviewService _productReviewService;
        public ProductReviewsController(IProductReviewService productReviewService)
        {
            _productReviewService = productReviewService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int producId, int id)
        {
            var model = await _productReviewService.GetProductReviewById(id);
            
            if(model == null)
                return NotFound();

            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> Post(int productId, AddProductReviewInputModel model)
        {
            if (model == null)
                return BadRequest("Data Invalid");

            await _productReviewService.AddProductReviewAsync(productId,model);
            
            //se tiver erro de validação, retornar BadRequest()
            return CreatedAtAction(nameof(GetById), new { id =model.Id, productId = productId }, model);
        }
    }
}
