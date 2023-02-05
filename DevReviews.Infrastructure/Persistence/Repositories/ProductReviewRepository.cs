using DevReviews.Core.Entities;
using DevReviews.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevReviews.Infrastructure.Persistence.Repositories
{
    public class ProductReviewRepository : IProductReviewRepository
    {
        private readonly DevReviewsDbContext _dbContext;
        public ProductReviewRepository(DevReviewsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ProductReview> GetReviewByIdAsync(int id)
        {
            return await _dbContext.ProductReviews.SingleOrDefaultAsync(p => p.Id == id);
        }
        public async Task AddReviewAsync(ProductReview productReview)
        {
            await _dbContext.ProductReviews.AddAsync(productReview);
            await _dbContext.SaveChangesAsync();
        }
    }
}
