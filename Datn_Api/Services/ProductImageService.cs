using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.ProductImageViewModels;
using Datn_Shared.ViewModels.WeightViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class ProductImageService : IProductImageService
    {
        private readonly MyDbContext _context;
        public ProductImageService(MyDbContext myDbContext)
        {
            _context = myDbContext;
        }
        public async Task<bool> CreateProductImage(CreateProductImage createProductImage)
        {
            ProductImage p = new ProductImage()
            {
                Id = Guid.NewGuid(),
                ProductDetailId = createProductImage.ProductDetailId,
                Name = createProductImage.Name,
                Status = createProductImage.Status,
            };
            try
            {
                await _context.ProductImages.AddAsync(p);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteProductImage(Guid id)
        {
            var t = await _context.ProductImages.FindAsync(id);
            if (t == null) return false;

            try
            {
                t.Status = 2;
                _context.ProductImages.Update(t);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<IEnumerable<ProductImage>> GetAllProductImage()
        {
            return await _context.ProductImages.ToListAsync();
        }

        public async Task<ProductImage> GetProductImageById(Guid id)
        {
            return await _context.ProductImages.FindAsync(id);
        }

        public async Task<IEnumerable<ProductImage>> GetProductImageByProductDetail(Guid id)
        {
            return await _context.ProductImages.Where(p => p.ProductDetailId == id).ToListAsync();
        }

        public async Task<bool> UpdateProductImage(Guid id, UpdateProductImage updateProductImage)
        {
            var t = await _context.ProductImages.FindAsync(id);
            if (t == null) return false;
            t.Name = updateProductImage.Name;
            t.Status = updateProductImage.Status;
            try
            {
                _context.ProductImages.Update(t);
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
