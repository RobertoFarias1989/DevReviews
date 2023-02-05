using AutoMapper;
using DevReviews.Application.Models;
using DevReviews.Application.Services.Interfaces;
using DevReviews.Core.Entities;
using DevReviews.Core.Repositories;


namespace DevReviews.Application.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductViewModel>> GetProductsAsync()
        {
            var productEntity = await _productRepository.GetAllAsync();

            return _mapper.Map<List<ProductViewModel>>(productEntity);
        }

        public async Task<ProductViewModel> GetProductByIdAsync(int id)
        {
            var productEntity = await _productRepository.GetByIdAsync(id);

            return _mapper.Map<ProductViewModel>(productEntity);
        }
        public async Task<ProductDetailsViewModel> GetProductDetailsByIdAsync(int id)
        {
            var productEntity = await _productRepository.GetDetailsByIdAsync(id);

            return _mapper.Map<ProductDetailsViewModel>(productEntity);
        }        

        public async Task AddProductAsync(AddProductInputModel model)
        {
            var productEntity = new Product(model.Title, model.Description, model.Price);
            //var productEntity = _mapper.Map<Product>(model);
            await _productRepository.AddAsync(productEntity);
            
        }        
        public async Task UpdateProductAsync(UpdateProductInputModel model)
        {
            var product = await _productRepository.GetByIdAsync(model.Id);

            product.Update(model.Description, model.Price);            

            await _productRepository.UpdateAsync(product);
        }       
        
    }
}
