using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.WishListViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class WishListService : IWishListService
    {
        private readonly MyDbContext _context;

        public WishListService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Like(Guid customerId, Guid productId)
        {
            try
            {
                var wl = await _context.WishLists.FirstOrDefaultAsync(p => p.CustomerId == customerId && p.ProductId == productId);
                if (wl == null)
                {
                    WishList p = new WishList()
                    {
                        Id = Guid.NewGuid(),
                        CustomerId = customerId,
                        ProductId = productId,
                    };
                    await _context.WishLists.AddAsync(p);
                }
                else
                {
                    _context.WishLists.Remove(wl);
                }
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<WishListView>> GetAllWishList()
        {
            List<WishListView> lstWishListView = new List<WishListView>();
            lstWishListView = await
                (from a in _context.WishLists
                 join b in _context.Customers on a.CustomerId equals b.Id
                 join c in _context.Products on a.ProductId equals c.Id
                 join d in _context.ProductDetails on a.ProductId equals d.ProductID
                 select new WishListView()
                 {
                     Id = a.Id,
                     CustomerId = a.CustomerId,
                     ProductId = a.ProductId,
                     ProductDetailId = d.Id,
                     Price = d.Price,
                     Customer = b,
                     Product = c
                 }).ToListAsync();
            return lstWishListView;
        }

        public async Task<WishListView> GetWishListById(Guid id)
        {
            WishListView lstWishListView = new WishListView();
            lstWishListView = await
                (from a in _context.WishLists
                 join b in _context.Customers on a.CustomerId equals b.Id
                 join c in _context.Products on a.ProductId equals c.Id
                 join d in _context.ProductDetails on a.ProductId equals d.ProductID
                 where a.Id == id
                 select new WishListView()
                 {
                     Id = a.Id,
                     CustomerId = a.CustomerId,
                     ProductId = a.ProductId,
                     ProductDetailId = d.Id,
                     Price = d.Price,
                     Customer = b,
                     Product = c
                 }).FirstAsync();
            return lstWishListView;
        }

        public async Task<List<WishListView>> GetWishListByCustomerId(Guid id)
        {
            List<WishListView> lstWishListView = new List<WishListView>();
            lstWishListView = await
                (from a in _context.WishLists
                 join b in _context.Customers on a.CustomerId equals b.Id
                 join c in _context.Products on a.ProductId equals c.Id
                 join d in _context.ProductDetails on a.ProductId equals d.ProductID
                 where a.CustomerId == id
                 select new WishListView()
                 {
                     Id = a.Id,
                     CustomerId = a.CustomerId,
                     ProductId = a.ProductId,
                     ProductDetailId = d.Id,
                     Price = d.Price,
                     Customer = b,
                     Product = c
                 }).ToListAsync();
            return lstWishListView;
        }

        public async Task<bool> CheckExistLike(Guid customerId, Guid productId)
        {
            var wl = await _context.WishLists.FirstOrDefaultAsync(p => p.CustomerId == customerId && p.ProductId == productId);
            if (wl == null)
            {
                return false;
            }
            return true;
        }
    }
}
