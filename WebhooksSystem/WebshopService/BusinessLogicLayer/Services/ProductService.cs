using System;
using BusinessLogicLayer.Interfaces.IServices;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services;

public class ProductService : IProductService
{
    public Task<Product> CreateProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> GetAllProduct()
    {
        throw new NotImplementedException();
    }
}
