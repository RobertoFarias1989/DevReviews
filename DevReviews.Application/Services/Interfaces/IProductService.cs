using DevReviews.Application.Models;
using DevReviews.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevReviews.Application.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductViewModel>> GetProductsAsync();
        Task<ProductViewModel> GetProductByIdAsync(int id);
        Task<ProductDetailsViewModel> GetProductDetailsByIdAsync(int id);
        Task AddProductAsync(AddProductInputModel model);
        Task UpdateProductAsync(UpdateProductInputModel model);
        
    }
}
