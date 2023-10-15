using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.ProductDetailViewModels;
using Datn_Shared.ViewModels.ProductViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class ProductService : IProductService
    {
        private readonly MyDbContext _context;
        public ProductService(MyDbContext myDbContext)
        {
            _context = myDbContext;
        }
        public async Task<bool> CreateProduct(CreateProduct product)
        {
            Product b = new Product()
            {
                Id = Guid.NewGuid(),
                CategoryID = product.CategoryID,

               
                Name = product.Name,
                Pin = product.Pin,
                Wrap = product.Wrap,
                Rings = product.Rings,
                AvailableQuantity = product.AvailableQuantity,
                Sold = product.Sold,
                Likes   = product.Likes,
                Producer = product.Producer,
                CreateDate = product.CreateDate,
                Status = product.Status,
                Description = product.Description,

            };
            try
            {
                await _context.Products.AddAsync(b);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteProduct(Guid id)
        {
            var prodt = _context.Products.Find(id);
            if (prodt == null) return false;
            try
            {
                prodt.Status = 2;
                _context.Products.Update(prodt);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<ProductView>> GetAllProduct()
        {
            List<ProductView> proview = new List<ProductView>();
            proview = await(
                from a in _context.Products
                join b in _context.Categories on a.CategoryID equals b.Id
                
                select new ProductView()
                {
                    Id = a.Id,
                    CategoryID  = a.CategoryID,
                    Name = a.Name,
                    Pin = a.Pin,
                    Wrap    = a.Wrap,
                    Rings = a.Rings, 
                    AvailableQuantity = a.AvailableQuantity,
                    Sold = a.Sold,
                    Likes   = a.Likes,
                    Producer = a.Producer,
                    CreateDate = a.CreateDate,
                    Status = a.Status,
                    Description = a.Description,
                    Category = b,

                }).ToListAsync();
            return proview;
        }

        public async Task<ProductView> GetProductById(Guid id)
        {
            ProductView proview = new ProductView();
            proview = await(
                from a in _context.Products
                join b in _context.Categories on a.CategoryID equals b.Id
                where a.Id == id
                select new ProductView()
                {
                    Id = a.Id,
                    CategoryID = a.CategoryID,
                    Name = a.Name,
                    Pin = a.Pin,
                    Wrap = a.Wrap,
                    Rings = a.Rings,
                    AvailableQuantity = a.AvailableQuantity,
                    Sold = a.Sold,
                    Likes = a.Likes,
                    Producer = a.Producer,
                    CreateDate = a.CreateDate,
                    Status = a.Status,
                    Description = a.Description,
                    Category = b,

                }).FirstAsync();
            return proview;
        }

        public async Task<IEnumerable<ProductView>> GetProductByName(string name)
        {
            List<ProductView> proview = new List<ProductView>();
            proview = await(
                from a in _context.Products
                join b in _context.Categories on a.CategoryID equals b.Id

                select new ProductView()
                {
                    Id = a.Id,
                    CategoryID = a.CategoryID,
                    Name = a.Name,
                    Pin = a.Pin,
                    Wrap = a.Wrap,
                    Rings = a.Rings,
                    AvailableQuantity = a.AvailableQuantity,
                    Sold = a.Sold,
                    Likes = a.Likes,
                    Producer = a.Producer,
                    CreateDate = a.CreateDate,
                    Status = a.Status,
                    Description = a.Description,
                    Category = b,

                }).Where(p => p.Name.ToLower().Contains(name.ToLower())).ToListAsync(); ;
            return proview;
        }

        public async Task<bool> UpdateProduct(Guid id, UpdateProduct product)
        {
            var n = _context.Products.Find(id);
            if (n == null) return false;
           n.Name = product.Name;
            n.Pin = product.Pin;
            n.Wrap = product.Wrap;
            n.Rings = product.Rings;
            n.AvailableQuantity = product.AvailableQuantity;
            n.Sold = product.Sold;
            n.Likes = product.Likes;
            n.Producer = product.Producer;
            n.CreateDate = product.CreateDate;
            n.Status = product.Status;
            n.Description = product.Description;
            try
            {
                _context.Products.Update(n);
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
