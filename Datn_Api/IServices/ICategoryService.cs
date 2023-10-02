using Datn_Shared.Models;
using Datn_Shared.ViewModels.CategoryViewModels;

namespace Datn_Api.IServices
{
    public interface ICategoryService
    {
        public Task<bool> CreateCategory(CreateCategory category);
        public Task<bool> UpdateCategory(Guid id, UpdateCategory category);
        public Task<bool> DeleteCategory(Guid id);
        public Task<Category> GetCategoryById(Guid id);
        public Task<List<Category>> GetCategoryByName(string name);
        public Task<List<Category>> GetAllCategory();
    }
}
