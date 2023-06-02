using Molla.Models;

namespace Molla.Service.Interfaces
{
    public interface ISliderService
    {
        Task<IEnumerable<Slider>> GetSliderAsync();
        Task<IEnumerable<SliderInfo>> GetInfoAsync();
    }
}
