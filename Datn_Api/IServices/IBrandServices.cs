using Datn_Shared.Models;
using Datn_Shared.ViewModels.BrandViewModels;
namespace Datn_Api.IServices
{
    public interface IBrandServices
    {
        public Task<bool> CreateBrand(CreateBrand brand);
        public Task<bool> UpdateBrand(Guid id, UpdateBrand brand);
        public Task<bool> DeleteBrand(Guid id);
        public Task<Brand> GetBrandById(Guid id);
        public Task<List<Brand>> GetBrandByName(string name);
        public Task<List<Brand>> GetAllBrand();
    }
}
