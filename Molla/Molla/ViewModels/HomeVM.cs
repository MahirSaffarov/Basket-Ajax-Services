using Molla.Models;

namespace Molla.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<SliderInfo> Infos { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
