using System;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly WebShopDbContext _context;
    public ProductRepository(WebShopDbContext context)
    {
        _context = context;
    }
    public async Task<Product> CreateProduct(Product product)
    {
        var sql = "INSERT INTO Product (Name, Description, Price, StockQuantity) VALUES(@p0, @p1, @p2, @p3)";
        await _context.Database.ExecuteSqlRawAsync(sql,
            product.Name,
            product.Description,
            product.Price,
            product.StockQuantity
        );

        await _context.SaveChangesAsync();

        return product;
    }

    public async Task<IEnumerable<Product>> GetAllProduct()
    {
        return await _context.Products
        .FromSqlRaw($"SELECT Id, Name, Description, Price, StockQuantity FROM Product")
        .ToListAsync();
    }
}
