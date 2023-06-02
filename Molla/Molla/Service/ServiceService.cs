using Microsoft.EntityFrameworkCore;
using Molla.Data;
using Molla.Models;
using Molla.Service.Interfaces;

namespace Molla.Service
{
    public class ServiceService : IServiceService
    {
        private readonly AppDbContext _context;
        public ServiceService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Servic>> GetAllAsync()=> await _context.Services.ToListAsync();
    }
}
