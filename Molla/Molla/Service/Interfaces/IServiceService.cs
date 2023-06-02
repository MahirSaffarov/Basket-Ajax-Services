using Molla.Models;

namespace Molla.Service.Interfaces
{
    public interface IServiceService
    {
        Task<IEnumerable<Servic>> GetAllAsync();
    }
}
