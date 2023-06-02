using Molla.Models;

namespace Molla.Service.Interfaces
{
    public interface ITeamService
    {
        Task<IEnumerable<Team>> GetAllAsync();
    }
}
