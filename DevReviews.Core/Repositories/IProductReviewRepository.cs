using DevReviews.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevReviews.Core.Repositories
{
    public interface IProductReviewRepository
    {
        Task<ProductReview> GetReviewByIdAsync(int id);
        Task AddReviewAsync(ProductReview productReview);
    }
}
