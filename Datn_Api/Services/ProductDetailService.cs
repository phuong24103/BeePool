using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.BillViewModels;
using Datn_Shared.ViewModels.ProductDetailViewModels;
using Datn_Shared.ViewModels.ProductViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class ProductDetailService : IProductDetailService
    {
        private readonly MyDbContext _context;
        public ProductDetailService(MyDbContext myDbContext)
        {
            _context = myDbContext;
        }
        public async Task<bool> CreateProductDetail(CreateProductDetail product)
        {
            ProductDetail b = new ProductDetail()
            {
                Id = Guid.NewGuid(),
                ProductID = product.ProductID,

                TipId = product.TipId,
                ShaftId = product.ShaftId,
                WeightId = product.WeightId,
                Quantity = product.Quantity,
                ImportPrice = product.ImportPrice,

                Price = product.Price,

                CreateDate = DateTime.Now,
                Status = product.Status,
                Description = product.Description,

            };
            try
            {
                await _context.ProductDetails.AddAsync(b);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteProductDetail(Guid id)
        {
            var prodt = _context.ProductDetails.Find(id);
            if (prodt == null) return false;
            try
            {
                prodt.Status = 2;
                _context.ProductDetails.Update(prodt);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<ViewProductDetail>> GetAllProductDetail()
        {
            List<ViewProductDetail> prodtview = new List<ViewProductDetail>();
            prodtview = await (
                from a in _context.ProductDetails
                join b in _context.Tips on a.TipId equals b.Id
                join c in _context.Shafts on a.ShaftId equals c.Id
                join d in _context.Weights on a.WeightId equals d.Id
                join e in _context.Products on a.ProductID equals e.Id
                select new ViewProductDetail()
                {
                    Id = a.Id,
                    TipId = a.TipId,
                    ShaftId = a.ShaftId,
                    WeightId = a.WeightId,
                    ProductID = a.ProductID,
                    Quantity = a.Quantity,
                    ImportPrice = a.ImportPrice,
                    Price = a.Price,
                    CreateDate = a.CreateDate,
                    Status = a.Status,
                    Description = a.Description,
                    Tip = b,
                    Shaft = c,
                    Weight = d,
                    Product = e,

                }).ToListAsync();
            return prodtview;
        }

        public async Task<ViewProductDetail> GetProductDetailById(Guid id)
        {
            ViewProductDetail prodtview = new ViewProductDetail();
            prodtview = await (
                from a in _context.ProductDetails
                join b in _context.Tips on a.TipId equals b.Id
                join c in _context.Shafts on a.ShaftId equals c.Id
                join d in _context.Weights on a.WeightId equals d.Id
                join e in _context.Products on a.ProductID equals e.Id
                where a.Id == id
                select new ViewProductDetail()
                {
                    Id = a.Id,
                    TipId = a.TipId,
                    ShaftId = a.ShaftId,
                    WeightId = a.WeightId,
                    ProductID = a.ProductID,
                    Quantity = a.Quantity,
                    ImportPrice = a.ImportPrice,
                    Price = a.Price,
                    CreateDate = a.CreateDate,
                    Status = a.Status,
                    Description = a.Description,
                    Tip = b,
                    Shaft = c,
                    Weight = d,
                    Product = e,

                }).FirstAsync();
            return prodtview;
        }

        public async Task<bool> IncreaseProductDetail(Guid id)
        {
            var productDetail = _context.ProductDetails.Find(id);
            if (productDetail == null) return false;
            try
            {
                productDetail.Quantity++;
                _context.ProductDetails.Update(productDetail);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> ReduceProductDetail(Guid id)
        {
            var productDetail = _context.ProductDetails.Find(id);
            if (productDetail == null) return false;
            try
            {
                if (productDetail.Quantity > 1)
                {
                    productDetail.Quantity--;
                    _context.ProductDetails.Update(productDetail);
                    await _context.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> ResetQuantityProductDetail(Guid id)
        {
            var productDetail = _context.ProductDetails.Find(id);
            if (productDetail == null) return false;
            try
            {
                productDetail.Quantity = 1;
                _context.ProductDetails.Update(productDetail);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateProductDetail(Guid id, UpdateProductDetail product)
        {
            var n = _context.ProductDetails.Find(id);
            if (n == null) return false;
            n.Quantity = product.Quantity;
            n.ImportPrice = product.ImportPrice;
            n.Price = product.Price;
            n.Status = product.Status;
            n.Description = product.Description;
            try
            {
                _context.ProductDetails.Update(n);
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
