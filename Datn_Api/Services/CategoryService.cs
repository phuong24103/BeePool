using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.CategoryViewModels;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Datn_Api.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly MyDbContext _context;

        public CategoryService(MyDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateCategory(CreateCategory category)
        {
            Category p = new Category()
            {
                Id = Guid.NewGuid(),
                Name = category.Name,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Status = 0,
            };
            try
            {
                await _context.Categories.AddAsync(p);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteCategory(Guid id)
        {
            var Category = _context.Categories.Find(id);
            if (Category == null) return false;
            try
            {
                Category.Status = 2;
                _context.Categories.Update(Category);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Category>> GetAllCategory()
        {
            return await _context.Categories.Where(p => p.Status != 2).ToListAsync();
        }

        public async Task<Category> GetCategoryById(Guid id)
        {
            return await _context.Categories.Where(p => p.Status != 2 && p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Category>> GetCategoryByName(string name)
        {
            return await _context.Categories.Where(p => p.Status != 2 && p.Name.ToLower().Contains(name.ToLower())).ToListAsync();
        }

        public async Task<bool> UpdateCategory(Guid id, UpdateCategory category)
        {
            try
            {
                var n = _context.Categories.Find(id);
                if (n == null) return false;
                n.Name = category.Name;
                n.UpdatedDate = DateTime.Now;
                n.Status = 1;
                _context.Categories.Update(n);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
