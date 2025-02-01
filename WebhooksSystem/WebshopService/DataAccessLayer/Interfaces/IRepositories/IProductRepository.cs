using System;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Interfaces.IRepositories;

public interface IProductRepository
{
    Task<Product> CreateProduct(Product product);
    Task<IEnumerable<Product>> GetAllProduct();
}
