using AutoMapper;
using DevReviews.Application.Models;
using DevReviews.Application.Services.Interfaces;
using DevReviews.Core.Entities;
using DevReviews.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevReviews.Application.Services.Implementations
{
    public class ProductReviewService : IProductReviewService
    {
        private readonly IProductReviewRepository _productReviewRepository;
        private readonly IMapper _mapper;

        public ProductReviewService(IProductReviewRepository productReviewRepository, IMapper mapper)
        {
            _productReviewRepository = productReviewRepository;
            _mapper = mapper;
        }
        public async Task<ProductReviewDetailsViewModel> GetProductReviewById(int id)
        {
            var entity = await _productReviewRepository.GetReviewByIdAsync(id);

            return _mapper.Map<ProductReviewDetailsViewModel>(entity);
        }
        public async Task AddProductReviewAsync(int productId,AddProductReviewInputModel model)
        {
            var reviewEntity = new ProductReview(model.Author, model.Rating,model.Comments, productId);

            await _productReviewRepository.AddReviewAsync(reviewEntity);
        }

        
    }
}
