using Microsoft.EntityFrameworkCore;
using Molla.Data;
using Molla.Models;
using Molla.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Molla.Service
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()=> await _context.Products.ToListAsync();
        public async Task<Product> GetByIdAsync(int id) => await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
        public async Task<IEnumerable<Product>> GetByCategoryAsync(int categoryId)=> await _context.Products.Include(p => p.Category).ToListAsync();
        public async Task<IEnumerable<Product>> GetByColorAsync(int colorId)=> await _context.Products.Include(p => p.Color).ToListAsync();
        public async Task<IEnumerable<Product>> GetBySizeAsync(int sizeId) => await _context.Products.Include(p => p.Size).ToListAsync();
        public async Task<IEnumerable<Product>> GetByDiscountAsync(int discountId)=>  await _context.Products.Include(p => p.Discount).ToListAsync();
        public async Task<IEnumerable<Product>> GetByImageAsync()=> await _context.Products.Include(p => p.ProductImage).ToListAsync();
    }
}
