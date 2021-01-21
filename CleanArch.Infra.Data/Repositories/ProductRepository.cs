using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {

        public ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public async Task<Product> GetById(int? id)
        {
            return await _context.Products.FindAsync(id);
        }

        public void Remove(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
