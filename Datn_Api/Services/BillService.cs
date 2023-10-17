using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.BillViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Net;

namespace Datn_Api.Services
{
    public class BillService : IBillService
    {
        private readonly MyDbContext _context;
        public BillService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateBill(CreateBill bill)
        {
            Bill b = new Bill()
            {
                Id = Guid.NewGuid(),
                CustomerId = bill.CustomerId,
                BillStatusId = bill.BillStatusId,
                PaymentId = bill.PaymentId,
                Price = bill.Price,
                CreateDate = bill.CreateDate,
                Address = bill.Address
            };
            try
            {
                await _context.Bills.AddAsync(b);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteBill(Guid id)
        {
            var bill = _context.Bills.Find(id);
            if (bill == null) return false;
            try
            {
                _context.Bills.Remove(bill);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<BillView>> GetAllBills()
        {
            List<BillView> billViews = new List<BillView>();
            billViews = await (
                from a in _context.Bills
                join b in _context.BillStatuses on a.BillStatusId equals b.Id
                join c in _context.Customers on a.CustomerId equals c.Id
                join d in _context.Payments on a.PaymentId equals d.Id
                select new BillView()
                {
                    Id = a.Id,
                    CustomerId = a.CustomerId,
                    BillStatusId = a.BillStatusId,
                    PaymentId = a.PaymentId,
                    Price = a.Price,
                    CreateDate = a.CreateDate,
                    Address = a.Address,
                    Customer = c,
                    BillStatus = b,
                    Payment = d
                }).ToListAsync();
            return billViews;
        }


        public async Task<BillView> GetBillById(Guid id)
        {
            List<BillView> billViews = new List<BillView>();
            billViews = await (
                from a in _context.Bills
                join b in _context.BillStatuses on a.BillStatusId equals b.Id
                join c in _context.Customers on a.CustomerId equals c.Id
                join d in _context.Payments on a.PaymentId equals d.Id
                select new BillView()
                {
                    Id = a.Id,
                    CustomerId = a.CustomerId,
                    BillStatusId = a.BillStatusId,
                    PaymentId = a.PaymentId,
                    Price = a.Price,
                    CreateDate = a.CreateDate,
                    Address = a.Address,
                    Customer = c,
                    BillStatus = b,
                    Payment = d
                }).ToListAsync();
            return billViews.FirstOrDefault(p => p.Id == id);
        }

        public async Task<bool> UpdateBill(Guid id, UpdateBill bill)
        {
            var b = _context.Bills.Find(id);
            if (b == null) return false;
            b.CustomerId = bill.CustomerId;
            b.BillStatusId = bill.BillStatusId;
            b.PaymentId = bill.PaymentId;
            b.Price = bill.Price;
            b.CreateDate = bill.CreateDate;
            b.Address = bill.Address;
            try
            {
                _context.Bills.Update(b);
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
