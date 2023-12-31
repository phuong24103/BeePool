﻿using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.CartDetailViewModels;
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
            var cartDetails = await _context.CartDetails.Include(p => p.ProductDetail).ToListAsync();

            List<CartDetailView> lstCartDetailView = new List<CartDetailView>();

            foreach (var cartDetail in cartDetails)
            {
                var productDetail = await _context.ProductDetails.Include(p => p.Product).FirstOrDefaultAsync(p => p.Id == cartDetail.ProductDetailId);
                string image = _context.ProductImages.FirstOrDefault(p => p.ProductDetailId == cartDetail.ProductDetailId).Name;
                var price = await _context.ProductDetails.FirstOrDefaultAsync(p => p.Id == cartDetail.ProductDetailId);
                string name = (productDetail != null && productDetail.Product != null) ? _context.Products.FirstOrDefault(p => p.Id == productDetail.ProductID).Name : null;
                var cart = await _context.Carts.Include(p => p.CartDetails).FirstOrDefaultAsync(p => p.CustomerId == cartDetail.CustomerId);

                lstCartDetailView.Add(new CartDetailView
                {
                    Id = cartDetail.Id,
                    CustomerId = cartDetail.CustomerId,
                    ProductDetailId = cartDetail.ProductDetailId,
                    Name = name,
                    Quantity = cartDetail.Quantity,
                    Price = cartDetail.Price,
                    ProductPrice = price.Price,
                    TotalMoney = cart.TotalMoney,
                    Image = image,
                    Cart = cartDetail.Cart,
                    ProductDetail = cartDetail.ProductDetail
                });
            }
            return lstCartDetailView;
        }

        public async Task<CartDetailView> GetCartDetailById(Guid id)
        {
            var cartDetail = await _context.CartDetails.Include(p => p.ProductDetail).FirstOrDefaultAsync(p => p.Id == id);

            CartDetailView cartDetailView = new CartDetailView();

            var productDetail = await _context.ProductDetails.Include(p => p.Product).FirstOrDefaultAsync(p => p.Id == cartDetail.ProductDetailId);
            string image = _context.ProductImages.FirstOrDefault(p => p.ProductDetailId == cartDetail.ProductDetailId).Name;
            var price = await _context.ProductDetails.FirstOrDefaultAsync(p => p.Id == cartDetail.ProductDetailId);
            string name = (productDetail != null && productDetail.Product != null) ? _context.Products.FirstOrDefault(p => p.Id == productDetail.ProductID).Name : null;
            var cart = await _context.Carts.Include(p => p.CartDetails).FirstOrDefaultAsync(p => p.CustomerId == cartDetail.CustomerId);

            cartDetailView = await
                (from a in _context.CartDetails
                 join b in _context.Carts on a.CustomerId equals b.CustomerId
                 join c in _context.ProductDetails on a.ProductDetailId equals c.Id
                 where a.Id == id
                 select new CartDetailView()
                 {
                     Id = cartDetail.Id,
                     CustomerId = cartDetail.CustomerId,
                     ProductDetailId = cartDetail.ProductDetailId,
                     Name = name,
                     Quantity = cartDetail.Quantity,
                     Price = cartDetail.Price,
                     ProductPrice = price.Price,
                     TotalMoney = cart.TotalMoney,
                     Image = image,
                     Cart = cartDetail.Cart,
                     ProductDetail = cartDetail.ProductDetail
                 }).FirstAsync();
            return cartDetailView;
        }

        public async Task<List<CartDetailView>> GetCartDetailByCustomerId(Guid id)
        {
            var cartDetails = await _context.CartDetails
        .Include(cd => cd.ProductDetail)
        .Include(cd => cd.ProductDetail.Product)
        .Include(cd => cd.Cart)
        .Where(p => p.CustomerId == id).ToListAsync();

            List<CartDetailView> lstCartDetailView = new List<CartDetailView>();

            foreach (var cartDetail in cartDetails)
            {
                var productDetail = await _context.ProductDetails.Include(p => p.Product).FirstOrDefaultAsync(p => p.Id == cartDetail.ProductDetailId);
                string image = _context.ProductImages.FirstOrDefault(p => p.ProductDetailId == cartDetail.ProductDetailId).Name;
                var price = await _context.ProductDetails.FirstOrDefaultAsync(p => p.Id == cartDetail.ProductDetailId);
                string name = (productDetail != null && productDetail.Product != null) ? _context.Products.FirstOrDefault(p => p.Id == productDetail.ProductID).Name : null;
                var cart = await _context.Carts.Include(p => p.CartDetails).FirstOrDefaultAsync(p => p.CustomerId == cartDetail.CustomerId);

                lstCartDetailView.Add(new CartDetailView
                {
                    Id = cartDetail.Id,
                    CustomerId = cartDetail.CustomerId,
                    ProductDetailId = cartDetail.ProductDetailId,
                    Name = name,
                    Quantity = cartDetail.Quantity,
                    Price = cartDetail.Price,
                    ProductPrice = price.Price,
                    TotalMoney = cart.TotalMoney,
                    Image = image,
                    Cart = cartDetail.Cart,
                    ProductDetail = cartDetail.ProductDetail,
                });
            }
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

        public async Task<bool> CreateCartDetailBySession(Guid customerId, List<CartDetailView> cartDetail)
        {
            try
            {
                for (int i = 0; i < cartDetail.Count; i++)
                {
                    var c = await _context.CartDetails.FirstOrDefaultAsync(p => p.CustomerId == customerId && p.ProductDetailId == cartDetail[i].ProductDetailId);
                    var cart = await _context.Carts.FirstOrDefaultAsync(p => p.CustomerId == customerId);
                    if (cart.Quantity == 0)
                    {
                        cart.TotalMoney = cartDetail[i].TotalMoney;
                    }
                    else
                    {
                        cart.TotalMoney += cartDetail[i].TotalMoney;
                    }
                    if (c == null)
                    {
                        if (cart.Quantity == 0)
                        {
                            cart.Status = 0;
                        }
                        CartDetail p = new CartDetail()
                        {
                            Id = cartDetail[i].Id,
                            CustomerId = customerId,
                            ProductDetailId = cartDetail[i].ProductDetailId,
                            Quantity = cartDetail[i].Quantity,
                            Price = cartDetail[i].Price,
                        };
                        await _context.CartDetails.AddAsync(p);
                        cart.Quantity++;
                    }
                    else
                    {
                        c.Quantity += cartDetail[i].Quantity;
                        c.Price += cartDetail[i].Price;
                        _context.CartDetails.Update(c);
                    }
                    _context.Carts.Update(cart);
                    await _context.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
