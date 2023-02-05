using AutoMapper;
using DevReviews.Application.Models;
using DevReviews.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevReviews.Application.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductReview, ProductReviewViewModel>();
            CreateMap<ProductReview, ProductReviewDetailsViewModel>();

            CreateMap<Product, ProductViewModel>();
            CreateMap<Product,ProductDetailsViewModel>();
        }
    }
}
