using Microsoft.EntityFrameworkCore;
using Molla.Data;
using Molla.Models;
using Molla.Service.Interfaces;

namespace Molla.Service
{
    public class BrandService : IBrandService
    {
        private readonly AppDbContext _context;
        public BrandService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Brand>> GetAllAsync() => await _context.Brands.ToListAsync();
    }
}
