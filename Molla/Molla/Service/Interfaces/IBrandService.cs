using Molla.Models;

namespace Molla.Service.Interfaces
{
    public interface IBrandService
    {
        Task<IEnumerable<Brand>> GetAllAsync();
    }
}
