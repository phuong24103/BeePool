using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.CategoryDetailViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class CategoryDetailService : ICategoryDetailService
    {
        private readonly MyDbContext _context;

        public CategoryDetailService(MyDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateCategoryDetail(CreateCategoryDetail categoryDetail)
        {
            CategoryDetail p = new CategoryDetail()
            {
                Id = Guid.NewGuid(),
                CategoryId = categoryDetail.CategoryId,
                ProductId = categoryDetail.ProductId,
                QuantityProduct = categoryDetail.QuantityProduct,
            };
            try
            {
                await _context.CategoriesDetail.AddAsync(p);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteCategoryDetail(Guid id)
        {
            var categoryDetail = _context.CategoriesDetail.Find(id);
            if (categoryDetail == null) return false;
            try
            {
                _context.CategoriesDetail.Remove(categoryDetail);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<CategoryDetail>> GetAllCategoryDetail()
        {
            List<CategoryDetail> lstCategoryDetailView = new List<CategoryDetail>();
            lstCategoryDetailView = await
                (from a in _context.CategoriesDetail
                 join b in _context.Categories on a.CategoryId equals b.Id
                 join c in _context.Products on a.ProductId equals c.Id
                 select new CategoryDetail()
                 {
                     Id = a.Id,
                     CategoryId = a.CategoryId,
                     ProductId = a.ProductId,
                     QuantityProduct = a.QuantityProduct,
                     Category = b,
                     Product = c
                 }).ToListAsync();
            return lstCategoryDetailView;
        }

        public async Task<List<CategoryDetail>> GetCategoryDetailByCategoryId(Guid id)
        {
            List<CategoryDetail> lstCategoryDetailView = new List<CategoryDetail>();
            lstCategoryDetailView = await
                (from a in _context.CategoriesDetail
                 join b in _context.Categories on a.CategoryId equals b.Id
                 join c in _context.Products on a.ProductId equals c.Id
                 where a.CategoryId == id
                 select new CategoryDetail()
                 {
                     Id = a.Id,
                     CategoryId = a.CategoryId,
                     ProductId = a.ProductId,
                     QuantityProduct = a.QuantityProduct,
                     Category = b,
                     Product = c
                 }).ToListAsync();
            return lstCategoryDetailView;
        }

        public async Task<CategoryDetail> GetCategoryDetailById(Guid id)
        {
            CategoryDetail lstCategoryDetailView = new CategoryDetail();
            lstCategoryDetailView = await
                (from a in _context.CategoriesDetail
                 join b in _context.Categories on a.CategoryId equals b.Id
                 join c in _context.Products on a.ProductId equals c.Id
                 where a.Id == id
                 select new CategoryDetail()
                 {
                     Id = a.Id,
                     CategoryId = a.CategoryId,
                     ProductId = a.ProductId,
                     QuantityProduct = a.QuantityProduct,
                     Category = b,
                     Product = c
                 }).FirstAsync();
            return lstCategoryDetailView;
        }

        public async Task<bool> UpdateCategoryDetail(Guid id, UpdateCategoryDetail categoryDetail)
        {
            var n = _context.CategoriesDetail.Find(id);
            if (n == null) return false;
            n.CategoryId = categoryDetail.CategoryId;
            n.ProductId = categoryDetail.ProductId;
            n.QuantityProduct = categoryDetail.QuantityProduct;
            try
            {
                _context.CategoriesDetail.Update(n);
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
