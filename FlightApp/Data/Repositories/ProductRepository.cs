using FlightApp.Models;
using FlightApp.Models.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly ApplicationDbContext _context;
        private readonly DbSet<Product> _products;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _products = dbContext.Products;
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            _products.Remove(product);
        }

        public IEnumerable<Product> getAll()
        {
            return _products.ToList();
        }

        public Product getById(int id)
        {
            return _products.SingleOrDefault(p => p.ProductId == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _products.Update(product);

        }
    }
}
