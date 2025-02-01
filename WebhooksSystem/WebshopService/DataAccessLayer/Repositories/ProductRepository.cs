using System;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces.IRepositories;

namespace DataAccessLayer.Repositories;

public class ProductRepository : IProductRepository
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
