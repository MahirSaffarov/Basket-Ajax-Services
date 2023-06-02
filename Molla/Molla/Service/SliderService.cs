using Microsoft.EntityFrameworkCore;
using Molla.Data;
using Molla.Models;
using Molla.Service.Interfaces;

namespace Molla.Service
{
    public class SliderService : ISliderService
    {
        private readonly AppDbContext _context;
        public SliderService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<SliderInfo>> GetInfoAsync() => await _context.SliderInfos.ToListAsync();

        public async Task<IEnumerable<Slider>> GetSliderAsync()=>await _context.Sliders.ToListAsync();
    }
}
