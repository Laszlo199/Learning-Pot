using System;
using BusinessLogicLayer.Interfaces.IServices;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces.IRepositories;

namespace BusinessLogicLayer.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    public Task<Product> CreateProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> GetAllProduct()
    {
        throw new NotImplementedException();
    }
}
