//using Datn_Api.Data;
//using Datn_Api.IServices;
//using Datn_Shared.Models;
//using Datn_Shared.ViewModels.CartDetailViewModels;
//using Microsoft.EntityFrameworkCore;

//namespace Datn_Api.Services
//{
//    public class CartDetailService : ICartDetailService
//    {
//        private readonly MyDbContext _context;

//        public CartDetailService(MyDbContext context)
//        {
//            _context = context;
//        }
//        public async Task<bool> CreateCartDetail(CreateCartDetail cartDetail)
//        {
//            var c = await _context.CartDetails.FirstOrDefaultAsync(p => p.CartId == cartDetail.CartId && p.ProductId == cartDetail.ProductId);
//            try
//            {
//                if (c == null)
//                {
//                    var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == cartDetail.ProductId);
//                    CartDetail p = new CartDetail()
//                    {
//                        Id = Guid.NewGuid(),
//                        CartId = cartDetail.CartId,
//                        ProductId = cartDetail.ProductId,
//                        Quantity = cartDetail.Quantity,
//                        Price = cartDetail.Price,
//                    };
//                    await _context.CartDetails.AddAsync(c);
//                }
//                else
//                {
//                    c.Quantity++;
//                    _context.CartDetails.Update(c);
//                }
//                await _context.SaveChangesAsync();
//                return true;
//            }
//            catch (Exception)
//            {
//                return false;
//            }
//        }

//        public async Task<bool> DeleteCartDetail(Guid id)
//        {
//            var cartDetail = _context.CartDetails.Find(id);
//            if (cartDetail == null) return false;
//            try
//            {
//                _context.CartDetails.Remove(cartDetail);
//                await _context.SaveChangesAsync();
//                return true;
//            }
//            catch (Exception)
//            {
//                return false;
//            }
//        }

//        public async Task<List<CartDetail>> GetAllCartDetail()
//        {
//            List<CartDetail> lstCartDetailView = new List<CartDetail>();
//            lstCartDetailView = await
//                (from a in _context.CartDetails
//                 join b in _context.Carts on a.CartId equals b.UserId
//                 join c in _context.Products on a.ProductId equals c.Id
//                 select new CartDetail()
//                 {
//                     Id = a.Id,
//                     CartId = a.CartId,
//                     ProductId = a.ProductId,
//                     Cart = b,
//                     Product = c
//                 }).ToListAsync();
//            return lstCartDetailView;
//        }

//        public async Task<CartDetail> GetCartDetailById(Guid id)
//        {
//            CartDetail lstCartDetailView = new CartDetail();
//            lstCartDetailView = await
//                (from a in _context.CartDetails
//                 join b in _context.Carts on a.CartId equals b.UserId
//                 join c in _context.Products on a.ProductId equals c.Id
//                 where a.Id == id
//                 select new CartDetail()
//                 {
//                     Id = a.Id,
//                     CartId = a.CartId,
//                     ProductId = a.ProductId,
//                     Cart = b,
//                     Product = c
//                 }).FirstAsync();
//            return lstCartDetailView;
//        }

//        public async Task<List<CartDetail>> GetCartDetailByUserId(Guid id)
//        {
//            List<CartDetail> lstCartDetailView = new List<CartDetail>();
//            lstCartDetailView = await
//                (from a in _context.CartDetails
//                 join b in _context.Carts on a.CartId equals b.UserId
//                 join c in _context.Products on a.ProductId equals c.Id
//                 where a.CartId == id
//                 select new CartDetail()
//                 {
//                     Id = a.Id,
//                     CartId = a.CartId,
//                     ProductId = a.ProductId,
//                     Cart = b,
//                     Product = c
//                 }).ToListAsync();
//            return lstCartDetailView;
//        }

//        public async Task<bool> IncreaseCartDetail(Guid id)
//        {
//            var cartDetail = _context.CartDetails.Find(id);
//            if (cartDetail == null) return false;
//            cartDetail.Quantity++;
//            cartDetail.Price += cartDetail.Product.Price;
//            try
//            {
//                _context.CartDetails.Update(cartDetail);
//                await _context.SaveChangesAsync();
//                return true;
//            }
//            catch (Exception)
//            {
//                return false;
//            }
//        }

//        public async Task<bool> ReduceCartDetail(Guid id)
//        {
//            var cartDetail = _context.CartDetails.Find(id);
//            if (cartDetail == null) return false;
//            cartDetail.Quantity--;
//            cartDetail.Price -= cartDetail.Product.Price;
//            try
//            {
//                if (cartDetail.Quantity > 1)
//                {
//                    cartDetail.Quantity--;
//                    cartDetail.Price -= cartDetail.Product.Price;
//                    _context.CartDetails.Update(cartDetail);
//                }
//                else
//                {
//                    _context.CartDetails.Remove(cartDetail);
//                }
//                await _context.SaveChangesAsync();
//                return true;
//            }
//            catch (Exception)
//            {
//                return false;
//            }
//        }
//    }
//}
