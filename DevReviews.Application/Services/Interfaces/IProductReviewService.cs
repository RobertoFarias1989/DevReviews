using DevReviews.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevReviews.Application.Services.Interfaces
{
    public interface IProductReviewService
    {
        Task<ProductReviewDetailsViewModel> GetProductReviewById(int id);
        Task AddProductReviewAsync(int productId,AddProductReviewInputModel model);
    }
}
