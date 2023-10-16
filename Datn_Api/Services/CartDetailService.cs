using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.CartDetailViewModels;
using Datn_Shared.ViewModels.CartViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class CartDetailService : ICartDetailService
    {
        private readonly MyDbContext _context;

        public CartDetailService(MyDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateCartDetail(CreateCartDetail cartDetail)
        {
            var c = await _context.CartDetails.FirstOrDefaultAsync(p => p.CustomerId == cartDetail.CustomerId && p.ProductDetailId == cartDetail.ProductDetailId);
            try
            {
                var cart = await _context.Carts.FirstOrDefaultAsync(p => p.CustomerId == cartDetail.CustomerId);
                Cart updateCart = new Cart();
                updateCart.CustomerId = cartDetail.CustomerId;
                if (c == null)
                {
                    var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == cartDetail.ProductDetailId);
                    CartDetail p = new CartDetail()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = cartDetail.CustomerId,
                        ProductDetailId = cartDetail.ProductDetailId,
                        Quantity = cartDetail.Quantity,
                        Price = cartDetail.Price,
                    };
                    await _context.CartDetails.AddAsync(c);
                }
                else
                {
                    c.Quantity++;
                    _context.CartDetails.Update(c);
                    updateCart.Quantity++;
                    updateCart.Status = 0;
                }
                updateCart.TotalMoney = cartDetail.Price;
                _context.Carts.Update(updateCart);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteCartDetail(Guid id)
        {
            var cartDetail = _context.CartDetails.Find(id);
            if (cartDetail == null) return false;
            try
            {
                _context.CartDetails.Remove(cartDetail);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<CartDetailView>> GetAllCartDetail()
        {
            List<CartDetailView> lstCartDetailView = new List<CartDetailView>();
            lstCartDetailView = await
                (from a in _context.CartDetails
                 join b in _context.Carts on a.CustomerId equals b.CustomerId
                 join c in _context.ProductDetails on a.ProductDetailId equals c.Id
                 select new CartDetailView()
                 {
                     Id = a.Id,
                     CustomerId = a.CustomerId,
                     ProductDetailId = a.ProductDetailId,
                     Quantity = a.Quantity,
                     Price = a.Price,
                     Cart = b,
                     ProductDetail = c
                 }).ToListAsync();
            return lstCartDetailView;
        }

        public async Task<CartDetailView> GetCartDetailById(Guid id)
        {
            CartDetailView lstCartDetailView = new CartDetailView();
            lstCartDetailView = await
                (from a in _context.CartDetails
                 join b in _context.Carts on a.CustomerId equals b.CustomerId
                 join c in _context.ProductDetails on a.ProductDetailId equals c.Id
                 where a.Id == id
                 select new CartDetailView()
                 {
                     Id = a.Id,
                     CustomerId = a.CustomerId,
                     ProductDetailId = a.ProductDetailId,
                     Quantity = a.Quantity,
                     Price = a.Price,
                     Cart = b,
                     ProductDetail = c
                 }).FirstAsync();
            return lstCartDetailView;
        }

        public async Task<List<CartDetailView>> GetCartDetailByCustomerId(Guid id)
        {
            List<CartDetailView> lstCartDetailView = new List<CartDetailView>();
            lstCartDetailView = await
                (from a in _context.CartDetails
                 join b in _context.Carts on a.CustomerId equals b.CustomerId
                 join c in _context.ProductDetails on a.ProductDetailId equals c.Id
                 where a.CustomerId == id
                 select new CartDetailView()
                 {
                     Id = a.Id,
                     CustomerId = a.CustomerId,
                     ProductDetailId = a.ProductDetailId,
                     Quantity = a.Quantity,
                     Price = a.Price,
                     Cart = b,
                     ProductDetail = c
                 }).ToListAsync();
            return lstCartDetailView;
        }

        public async Task<bool> IncreaseCartDetail(Guid id)
        {
            var cartDetail = _context.CartDetails.Find(id);
            if (cartDetail == null) return false;
            cartDetail.Quantity++;
            cartDetail.Price += cartDetail.ProductDetail.Price;
            try
            {
                var cart = _context.Carts.Find(cartDetail.CustomerId);
                cart.TotalMoney += cartDetail.Price;
                _context.Carts.Update(cart);
                _context.CartDetails.Update(cartDetail);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> ReduceCartDetail(Guid id)
        {
            var cartDetail = _context.CartDetails.Find(id);
            if (cartDetail == null) return false;
            cartDetail.Quantity--;
            cartDetail.Price -= cartDetail.ProductDetail.Price;
            try
            {
                var cart = _context.Carts.Find(cartDetail.CustomerId);
                if (cartDetail.Quantity > 1)
                {
                    cartDetail.Quantity--;
                    cartDetail.Price -= cartDetail.ProductDetail.Price;
                    _context.CartDetails.Update(cartDetail);
                }
                else
                {
                    _context.CartDetails.Remove(cartDetail);
                    cart.Quantity--;
                }
                cart.TotalMoney -= cartDetail.Price;
                _context.Carts.Update(cart);
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
