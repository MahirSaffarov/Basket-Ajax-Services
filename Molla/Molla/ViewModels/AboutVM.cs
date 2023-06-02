using Molla.Models;

namespace Molla.ViewModels
{
    public class AboutVM
    {
        public IEnumerable<Team> Teams { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
    }
}
