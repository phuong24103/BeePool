using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
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

        public async Task<bool> Like(Guid userId, Guid productId)
        {
            try
            {
                var wishList = await _context.WishLists.FirstOrDefaultAsync(p => p.UserId == userId && p.ProductId == productId);
                if (wishList == null)
                {
                    WishList p = new WishList()
                    {
                        Id = Guid.NewGuid(),
                        UserId = userId,
                        ProductId = productId,
                    };
                    await _context.WishLists.AddAsync(p);
                }
                else
                {
                    _context.WishLists.Remove(wishList);
                }
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<WishList>> GetAllWishList()
        {
            List<WishList> lstWishListView = new List<WishList>();
            lstWishListView = await
                (from a in _context.WishLists
                 join b in _context.Users on a.UserId equals b.Id
                 join c in _context.Products on a.ProductId equals c.Id
                 select new WishList()
                 {
                     Id = a.Id,
                     UserId = a.UserId,
                     ProductId = a.ProductId,
                     User = b,
                     Product = c
                 }).ToListAsync();
            return lstWishListView;
        }

        public async Task<WishList> GetWishListById(Guid id)
        {
            WishList lstWishListView = new WishList();
            lstWishListView = await
                (from a in _context.WishLists
                 join b in _context.Users on a.UserId equals b.Id
                 join c in _context.Products on a.ProductId equals c.Id
                 where a.Id == id
                 select new WishList()
                 {
                     Id = a.Id,
                     UserId = a.UserId,
                     ProductId = a.ProductId,
                     User = b,
                     Product = c
                 }).FirstAsync();
            return lstWishListView;
        }

        public async Task<List<WishList>> GetWishListByUserId(Guid id)
        {
            List<WishList> lstWishListView = new List<WishList>();
            lstWishListView = await
                (from a in _context.WishLists
                 join b in _context.Users on a.UserId equals b.Id
                 join c in _context.Products on a.ProductId equals c.Id
                 where a.UserId == id
                 select new WishList()
                 {
                     Id = a.Id,
                     UserId = a.UserId,
                     ProductId = a.ProductId,
                     User = b,
                     Product = c
                 }).ToListAsync();
            return lstWishListView;
        }
    }
}
