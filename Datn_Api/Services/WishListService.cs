using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.ProductViewModels;
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
            var lstWishList = await _context.WishLists.Include(p => p.Product).ToListAsync();

            List<WishListView> lstWishListView = new List<WishListView>();

            foreach (var wishList in lstWishList)
            {
                var product = await _context.Products.Where(p => p.Id == wishList.ProductId).Include(p => p.ProductDetails).FirstOrDefaultAsync();
                if (product != null)
                {
                    double price = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Price : 0;
                    Guid productDetailId = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Id : Guid.Empty;
                    string image = (product != null && product.ProductDetails.FirstOrDefault() != null) ? _context.ProductImages.FirstOrDefault(p => p.ProductDetailId == productDetailId).Name : null;

                    lstWishListView.Add(new WishListView
                    {
                        Id = wishList.Id,
                        CustomerId = wishList.CustomerId,
                        ProductId = wishList.ProductId,
                        ProductDetailId = productDetailId,
                        Price = price,
                        Image = image,
                        Customer = wishList.Customer,
                        Product = wishList.Product,
                    });
                }
            }
            return lstWishListView;
        }

        public async Task<WishListView> GetWishListById(Guid id)
        {
            WishListView wishListView = new WishListView();
            var product = await _context.Products.Include(p => p.ProductDetails).FirstOrDefaultAsync(p => p.Id == id);
            if (product != null)
            {
                double price = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Price : 0;
                Guid productDetailId = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Id : Guid.Empty;
                string image = (product != null && product.ProductDetails.FirstOrDefault() != null) ? _context.ProductImages.FirstOrDefault(p => p.ProductDetailId == productDetailId).Name : null;

                wishListView = await (
                    from a in _context.WishLists
                    join b in _context.Customers on a.CustomerId equals b.Id
                    join c in _context.Products on a.ProductId equals c.Id
                    where a.Id == id
                    select new WishListView()
                    {
                        Id = a.Id,
                        CustomerId = a.CustomerId,
                        ProductId = a.ProductId,
                        ProductDetailId = productDetailId,
                        Price = price,
                        Image = image,
                        Customer = b,
                        Product = c
                    }).FirstAsync();
            }
            return wishListView;
        }

        public async Task<List<WishListView>> GetWishListByCustomerId(Guid id)
        {
            var lstWishList = await _context.WishLists.Where(p => p.CustomerId == id).Include(p => p.Product).ToListAsync();

            List<WishListView> lstWishListView = new List<WishListView>();

            foreach (var wishList in lstWishList)
            {
                var product = await _context.Products.Where(p => p.Id == wishList.ProductId).Include(p => p.ProductDetails).FirstOrDefaultAsync();
                if (product != null)
                {
                    double price = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Price : 0;
                    Guid productDetailId = (product != null && product.ProductDetails.FirstOrDefault() != null) ? product.ProductDetails.FirstOrDefault().Id : Guid.Empty;
                    string image = (product != null && product.ProductDetails.FirstOrDefault() != null) ? _context.ProductImages.FirstOrDefault(p => p.ProductDetailId == productDetailId).Name : null;

                    lstWishListView.Add(new WishListView
                    {
                        Id = wishList.Id,
                        CustomerId = wishList.CustomerId,
                        ProductId = wishList.ProductId,
                        ProductDetailId = productDetailId,
                        Price = price,
                        Image = image,
                        Customer = wishList.Customer,
                        Product = wishList.Product,
                    });
                }
            }
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
