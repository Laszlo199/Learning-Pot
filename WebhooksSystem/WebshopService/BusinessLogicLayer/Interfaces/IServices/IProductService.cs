using System;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Interfaces.IServices;

public interface IProductService
{
    Task<Product> CreateProduct(Product product);
    Task<IEnumerable<Product>> GetAllProduct();
}
