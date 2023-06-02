using Microsoft.EntityFrameworkCore;
using Molla.Data;
using Molla.Models;
using Molla.Service.Interfaces;

namespace Molla.Service
{
    public class TeamService : ITeamService
    {
        private readonly AppDbContext _context;
        public TeamService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Team>> GetAllAsync()=> await _context.Teams.ToListAsync();
    }
}
