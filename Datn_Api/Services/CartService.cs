using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.CartViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class CartService : ICartService
    {
        private readonly MyDbContext _context;

        public CartService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateCart(CreateCart cart)
        {
            Cart c = new Cart()
            {                
                CustomerId = cart.CustomerId,
                Quantity = cart.Quantity,
                TotalMoney = cart.TotalMoney,
                Status = cart.Status
            };
            try
            {
                await _context.Carts.AddAsync(c);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteCart(Guid id)
        {
            var cart = _context.Carts.Find(id);
            if (cart == null) return false;
            try
            {
                cart.Quantity = 0;
                cart.TotalMoney = 0;
                cart.Status = 2;
                _context.Carts.Update(cart);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<CartView>> GetAllCart()
        {
            List<CartView> lstCartView = new List<CartView>();
            lstCartView = await
                (from a in _context.Carts
                 join b in _context.Customers on a.CustomerId equals b.Id
                 select new CartView()
                 {
                     CustomerId = a.CustomerId,
                     Quantity = a.Quantity,
                     TotalMoney = a.TotalMoney,
                     Status = a.Status,
                 }).ToListAsync();
            return lstCartView;
        }

        public async Task<CartView> GetCartById(Guid id)
        {
            CartView lstCartView = new CartView();
            lstCartView = await
                (from a in _context.Carts
                 join b in _context.Customers on a.CustomerId equals b.Id
                 where a.CustomerId == id
                 select new CartView()
                 {
                     CustomerId = b.Id,
                     Quantity = a.Quantity,
                     TotalMoney = a.TotalMoney,
                     Status = a.Status,
                 }).FirstAsync();
            return lstCartView;
        }

        public async Task<bool> UpdateCart(Guid id, UpdateCart cart)
        {
            var n = _context.Carts.Find(id);
            if (n == null) return false;
            n.Quantity = cart.Quantity;
            n.TotalMoney = cart.TotalMoney;
            n.Status = cart.Status;
            try
            {
                _context.Carts.Update(n);
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