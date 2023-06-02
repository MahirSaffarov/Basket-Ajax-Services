using Molla.Models;

namespace Molla.Service.Interfaces
{
    public interface IBlogService
    {
        Task<IEnumerable<Blog>> GetAllAsync(); 
    }
}
