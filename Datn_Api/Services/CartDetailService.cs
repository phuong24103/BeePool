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
                var product = await _context.ProductDetails.FirstOrDefaultAsync(p => p.Id == cartDetail.ProductDetailId);
                var cart = await _context.Carts.FirstOrDefaultAsync(p => p.CustomerId == cartDetail.CustomerId);
                if (cart.Quantity == 0)
                {
                    cart.TotalMoney = product.Price * cartDetail.Quantity;
                }
                else
                {
                    cart.TotalMoney += product.Price * cartDetail.Quantity;
                }
                if (c == null)
                {
                    if (cart.Quantity == 0)
                    {
                        cart.Status = 0;
                    }
                    CartDetail p = new CartDetail()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = cartDetail.CustomerId,
                        ProductDetailId = cartDetail.ProductDetailId,
                        Quantity = cartDetail.Quantity,
                        Price = product.Price * cartDetail.Quantity,
                    };
                    await _context.CartDetails.AddAsync(p);
                    cart.Quantity++;
                }
                else
                {
                    c.Quantity += cartDetail.Quantity;
                    c.Price += product.Price * cartDetail.Quantity;
                    _context.CartDetails.Update(c);
                }
                product.Quantity = 1;
                _context.ProductDetails.Update(product);
                _context.Carts.Update(cart);
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
                var cart = _context.Carts.Find(cartDetail.CustomerId);
                cart.Quantity--;
                cart.TotalMoney -= cartDetail.Price;
                _context.Carts.Update(cart);
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
                 join d in _context.Products on c.ProductID equals d.Id
                 select new CartDetailView()
                 {
                     Id = a.Id,
                     CustomerId = a.CustomerId,
                     ProductDetailId = a.ProductDetailId,
                     Name = d.Name,
                     Quantity = a.Quantity,
                     Price = a.Price,
                     Description = d.Description,
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
                 join d in _context.Products on c.ProductID equals d.Id
                 where a.Id == id
                 select new CartDetailView()
                 {
                     Id = a.Id,
                     CustomerId = a.CustomerId,
                     ProductDetailId = a.ProductDetailId,
                     Name = d.Name,
                     Quantity = a.Quantity,
                     Price = a.Price,
                     Description = d.Description,
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
                 join d in _context.Products on c.ProductID equals d.Id
                 where a.CustomerId == id
                 select new CartDetailView()
                 {
                     Id = a.Id,
                     CustomerId = a.CustomerId,
                     ProductDetailId = a.ProductDetailId,
                     Name = d.Name,
                     Quantity = a.Quantity,
                     Price = a.Price,
                     Description = d.Description,
                     Cart = b,
                     ProductDetail = c
                 }).ToListAsync();
            return lstCartDetailView;
        }

        public async Task<bool> IncreaseCartDetail(Guid id)
        {
            var cartDetail = _context.CartDetails.Find(id);
            if (cartDetail == null) return false;
            try
            {
                cartDetail.Quantity++;
                var productDetail = _context.ProductDetails.Find(cartDetail.ProductDetailId);
                cartDetail.Price += productDetail.Price;
                _context.CartDetails.Update(cartDetail);
                var cart = _context.Carts.Find(cartDetail.CustomerId);
                cart.TotalMoney += productDetail.Price;
                _context.Carts.Update(cart);
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
            try
            {
                var cart = _context.Carts.Find(cartDetail.CustomerId);
                var productDetail = _context.ProductDetails.Find(cartDetail.ProductDetailId);
                if (cartDetail.Quantity > 1)
                {
                    cartDetail.Quantity--;
                    cartDetail.Price -= productDetail.Price;
                    _context.CartDetails.Update(cartDetail);
                }
                else
                {
                    _context.CartDetails.Remove(cartDetail);
                    cart.Quantity--;
                }
                cart.TotalMoney -= productDetail.Price;
                _context.Carts.Update(cart);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAllCartDetail(Guid id)
        {
            var customer = _context.Customers.Find(id);
            if (customer == null) return false;
            try
            {
                var cartDetail = _context.CartDetails.Where(p => p.CustomerId == customer.Id);
                foreach (var item in cartDetail)
                {
                    _context.CartDetails.Remove(item);
                }
                var cart = _context.Carts.Find(customer.Id);
                cart.Quantity = 0;
                cart.TotalMoney = 0;
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
