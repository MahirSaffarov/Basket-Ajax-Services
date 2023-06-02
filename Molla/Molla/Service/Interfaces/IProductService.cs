using Molla.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Molla.Service.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task<IEnumerable<Product>> GetByCategoryAsync(int categoryId);
        Task<IEnumerable<Product>> GetByColorAsync(int colorId);
        Task<IEnumerable<Product>> GetBySizeAsync(int sizeId);
        Task<IEnumerable<Product>> GetByDiscountAsync(int discountId);
        Task<IEnumerable<Product>> GetByImageAsync();
    }
}
