using Datn_Shared.Models;
using Datn_Shared.ViewModels.CategoryDetailViewModels;

namespace Datn_Api.IServices
{
    public interface ICategoryDetailService
    {
        public Task<bool> CreateCategoryDetail(CreateCategoryDetail categoryDetail);
        public Task<bool> UpdateCategoryDetail(Guid id, UpdateCategoryDetail categoryDetail);
        public Task<bool> DeleteCategoryDetail(Guid id);
        public Task<CategoryDetail> GetCategoryDetailById(Guid id);
        public Task<List<CategoryDetail>> GetCategoryDetailByCategoryId(Guid id);
        public Task<List<CategoryDetail>> GetAllCategoryDetail();
    }
}
