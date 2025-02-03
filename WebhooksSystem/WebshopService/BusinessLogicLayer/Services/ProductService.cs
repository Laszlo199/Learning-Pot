using System;
using BusinessLogicLayer.Interfaces.IServices;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces.IRepositories;

namespace BusinessLogicLayer.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public async Task<Product> CreateProduct(Product product)
    {
        return await _productRepository.CreateProduct(product);
    }

    public async Task<IEnumerable<Product>> GetAllProduct()
    {
        return await _productRepository.GetAllProduct();
    }
}
