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
                foreach (var item in product.Image)
                {
                    ProductImage productImage = new ProductImage()
                    {
                        Id = Guid.NewGuid(),
                        ProductDetailId = b.Id,
                        Name = item,
                        Status = product.Status,
                    };
                    await _context.ProductImages.AddAsync(productImage);
                }

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
        public async Task<ViewProductDetail> GetProductdtByTip(Guid id,Guid Tipid)
        {
            var prodtt = await _context.ProductDetails.FirstOrDefaultAsync(p => p.Id == id);
            ViewProductDetail prodtview = new ViewProductDetail();
            prodtview = await  (
                from a in _context.ProductDetails
                join b in _context.Tips on a.TipId equals b.Id
                join c in _context.Shafts on a.ShaftId equals c.Id
                join d in _context.Weights on a.WeightId equals d.Id
                join e in _context.Products on a.ProductID equals e.Id
                where a.TipId == Tipid && a.ShaftId == prodtt.ShaftId && a.WeightId == prodtt.WeightId && a.ProductID == prodtt.ProductID
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

                }).FirstOrDefaultAsync();
            return prodtview;
        }  
        public async Task<ViewProductDetail> GetProductdtByShaft(Guid id,Guid Shaftid)
        {
            var prodtt = await _context.ProductDetails.FirstOrDefaultAsync(p => p.Id == id);
            ViewProductDetail prodtview = new ViewProductDetail();
            prodtview = await  (
                from a in _context.ProductDetails
                join b in _context.Tips on a.TipId equals b.Id
                join c in _context.Shafts on a.ShaftId equals c.Id
                join d in _context.Weights on a.WeightId equals d.Id
                join e in _context.Products on a.ProductID equals e.Id
                where a.ShaftId == Shaftid && a.TipId == prodtt.TipId && a.WeightId == prodtt.WeightId && a.ProductID == prodtt.ProductID
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

                }).FirstOrDefaultAsync();
            return prodtview;
        }   
        public async Task<ViewProductDetail> GetProductdtByWeight(Guid id,Guid Weightid)
        {
            var prodtt = await _context.ProductDetails.FirstOrDefaultAsync(p => p.Id == id);
            ViewProductDetail prodtview = new ViewProductDetail();
            prodtview = await  (
                from a in _context.ProductDetails
                join b in _context.Tips on a.TipId equals b.Id
                join c in _context.Shafts on a.ShaftId equals c.Id
                join d in _context.Weights on a.WeightId equals d.Id
                join e in _context.Products on a.ProductID equals e.Id
                where a.WeightId == Weightid && a.TipId == prodtt.TipId && a.ShaftId == prodtt.ShaftId && a.ProductID == prodtt.ProductID
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

                }).FirstOrDefaultAsync();
            return prodtview;
        } 
      
        public async Task<IEnumerable<ViewProductDetail>> GetAllProductDetail()
        {
            var products = await _context.ProductDetails.Include(p => p.ProductImages).ToListAsync();
          

            List<ViewProductDetail> proview = new List<ViewProductDetail>();

            foreach (var product in products)
            {
                var pro = await _context.Products.FirstOrDefaultAsync(p => p.Id == product.ProductID);
                var tip = await _context.Tips.FirstOrDefaultAsync(p=>p.Id == product.TipId);
                var shaft = await _context.Shafts.FirstOrDefaultAsync(p=>p.Id == product.ShaftId);
                var weight = await _context.Weights.FirstOrDefaultAsync(p=>p.Id == product.WeightId);
                Guid productDetailId = (product != null && product.ProductImages.FirstOrDefault() != null) ? product.ProductImages.FirstOrDefault().Id : Guid.Empty;
                if (productDetailId != Guid.Empty && product.Status != 2)
                {

                    var anh = await _context.ProductImages.Where(p => p.ProductDetailId == product.Id).ToListAsync();
                    List <string> productImages = new List<string>();
                    foreach (var image in anh)
                    {

                        productImages.Add(image.Name);
                    }
                    proview.Add(new ViewProductDetail
                    {
                     
                     Id = product.Id,
                     TipId = product.TipId,
                     ShaftId = product.ShaftId,
                     WeightId = product.WeightId,
                     ProductID = product.ProductID,
                     Quantity = product.Quantity,
                     ImportPrice = product.ImportPrice,
                     Price = product.Price,
                     CreateDate = product.CreateDate,
                     Status = product.Status,
                     Description = product.Description,
                     Tip = tip,
                     Shaft = shaft,
                     Weight = weight,
                     Product = pro,
                     Image = productImages,

                    });
                }

            }
            return proview;
            /* List<ViewProductDetail> prodtview = new List<ViewProductDetail>();
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
             return prodtview;*/

        }

        public async Task<ViewProductDetail> GetProductDetailById(Guid id)
        {
            var product = await _context.ProductDetails.Include(p => p.ProductImages).FirstOrDefaultAsync(p =>p.Id == id);


            ViewProductDetail proview = new ViewProductDetail();

          
                var pro = await _context.Products.FirstOrDefaultAsync(p => p.Id == product.ProductID);
                var tip = await _context.Tips.FirstOrDefaultAsync(p => p.Id == product.TipId);
                var shaft = await _context.Shafts.FirstOrDefaultAsync(p => p.Id == product.ShaftId);
                var weight = await _context.Weights.FirstOrDefaultAsync(p => p.Id == product.WeightId);
                Guid productDetailId = (product != null && product.ProductImages.FirstOrDefault() != null) ? product.ProductImages.FirstOrDefault().Id : Guid.Empty;
                if (productDetailId != Guid.Empty && product.Status != 2)
                {

                    var anh = await _context.ProductImages.Where(p => p.ProductDetailId == product.Id).ToListAsync();
                    List<string> productImages = new List<string>();
                    foreach (var image in anh)
                    {

                        productImages.Add(image.Name);
                    }
                    proview = (new ViewProductDetail
                    {

                        Id = product.Id,
                        TipId = product.TipId,
                        ShaftId = product.ShaftId,
                        WeightId = product.WeightId,
                        ProductID = product.ProductID,
                        Quantity = product.Quantity,
                        ImportPrice = product.ImportPrice,
                        Price = product.Price,
                        CreateDate = product.CreateDate,
                        Status = product.Status,
                        Description = product.Description,
                        Tip = tip,
                        Shaft = shaft,
                        Weight = weight,
                        Product = pro,
                        Image = productImages,

                    });
                

            }
            return proview;
            ////ViewProductDetail prodtview = new ViewProductDetail();
            ////prodtview = await (
            ////    from a in _context.ProductDetails
            ////    join b in _context.Tips on a.TipId equals b.Id
            ////    join c in _context.Shafts on a.ShaftId equals c.Id
            ////    join d in _context.Weights on a.WeightId equals d.Id
            ////    join e in _context.Products on a.ProductID equals e.Id
            ////    where a.Id == id
            ////    select new ViewProductDetail()
            ////    {
            ////        Id = a.Id,
            ////        TipId = a.TipId,
            ////        ShaftId = a.ShaftId,
            ////        WeightId = a.WeightId,
            ////        ProductID = a.ProductID,
            ////        Quantity = a.Quantity,
            ////        ImportPrice = a.ImportPrice,
            ////        Price = a.Price,
            ////        CreateDate = a.CreateDate,
            ////        Status = a.Status,
            ////        Description = a.Description,
            ////        Tip = b,
            ////        Shaft = c,
            ////        Weight = d,
            ////        Product = e,

            ////    }).FirstAsync();
            ////return prodtview;
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
            n.ProductID = product.ProductID;
            n.TipId = product.TipId;
            n.ShaftId = product.ShaftId;
            n.WeightId =product.WeightId;
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
