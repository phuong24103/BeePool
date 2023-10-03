using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.BillDetailViewModels;
using Datn_Shared.ViewModels.BillViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class BillDetailService : IBillDetailService
    {
        private readonly MyDbContext _context;
        public BillDetailService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateBillDetails(CreateBillDetail billDetail)
        {
            BillDetail b = new BillDetail()
            {
                Id = Guid.NewGuid(),
                BillId = billDetail.BillId,
                ProductId = billDetail.ProductId,
                Quantity = billDetail.Quantity,
                Price = billDetail.Price,
            };
            try
            {
                await _context.BillDetails.AddAsync(b);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteBillDetails(Guid id)
        {
            var billDetail = _context.BillDetails.Find(id);
            if (billDetail == null) return false;
            try
            {
                _context.BillDetails.Remove(billDetail);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<BillDetailView>> GetAllBillDetails()
        {
            List<BillDetailView> billDetailViews = new List<BillDetailView>();
            billDetailViews = await (
                from a in _context.BillDetails
                join b in _context.Bills on a.BillId equals b.Id
                join c in _context.Products on a.ProductId equals c.Id
                select new BillDetailView()
                {
                    Id = a.Id,
                    BillId = a.BillId,
                    ProductId = a.ProductId,
                    Quantity = a.Quantity,
                    Price = a.Price,
                    Bill = b,
                    Product = c
                }).ToListAsync();
            return billDetailViews;
        }

        public async Task<BillDetailView> GetBillDetailsById(Guid id)
        {
            List<BillDetailView> billDetailViews = new List<BillDetailView>();
            billDetailViews = await (
                from a in _context.BillDetails
                join b in _context.Bills on a.BillId equals b.Id
                join c in _context.Products on a.ProductId equals c.Id
                select new BillDetailView()
                {
                    Id = a.Id,
                    BillId = a.BillId,
                    ProductId = a.ProductId,
                    Quantity = a.Quantity,
                    Price = a.Price,
                    Bill = b,
                    Product = c
                }).ToListAsync();
            return billDetailViews.FirstOrDefault(b => b.Id == id);
        }

        public async Task<bool> UpdateBillDetails(Guid id, UpdateBillDetail billDetail)
        {
            var b = _context.BillDetails.Find(id);
            if (b == null) return false;
            b.BillId = billDetail.BillId;
            b.ProductId = billDetail.ProductId;
            b.Quantity = billDetail.Quantity;
            b.Price = billDetail.Price;
            try
            {
                _context.BillDetails.Update(b);
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
