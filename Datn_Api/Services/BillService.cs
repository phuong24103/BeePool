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
                Id = bill.Id,
                CustomerId = bill.CustomerId,
                BillStatusId = bill.BillStatusId,
                PaymentId = bill.PaymentId,
                Price = bill.Price,
                CreateDate = bill.CreateDate,
                Address = bill.Address,
                CustomerName = bill.CustomerName,
                CustomerPhone = bill.CustomerPhone,
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

        public async Task<IEnumerable<BillView>> GetAllBills()
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
                    CustomerName = a.CustomerName,
                    CustomerPhone = a.CustomerPhone,
                    Customer = c,
                    BillStatus = b,
                    Payment = d
                }).ToListAsync();
            return billViews;
        }

        public async Task<IEnumerable<BillView>> GetBillByCustomerId(Guid id)
        {
            List<BillView> billViews = new List<BillView>();
            billViews = await(
                from a in _context.Bills
                join b in _context.BillStatuses on a.BillStatusId equals b.Id
                join c in _context.Customers on a.CustomerId equals c.Id
                join d in _context.Payments on a.PaymentId equals d.Id
                where a.CustomerId == id
                select new BillView()
                {
                    Id = a.Id,
                    CustomerId = a.CustomerId,
                    BillStatusId = a.BillStatusId,
                    PaymentId = a.PaymentId,
                    Price = a.Price,
                    CreateDate = a.CreateDate,
                    Address = a.Address,
                    CustomerName = a.CustomerName,
                    CustomerPhone = a.CustomerPhone,
                    Customer = c,
                    BillStatus = b,
                    Payment = d
                }).ToListAsync();
            return billViews;
        }

        public async Task<BillView> GetBillById(Guid id)
        {
            BillView billViews = new BillView();
            billViews = await (
                from a in _context.Bills
                join b in _context.BillStatuses on a.BillStatusId equals b.Id
                join c in _context.Customers on a.CustomerId equals c.Id
                join d in _context.Payments on a.PaymentId equals d.Id
                where a.Id == id
                select new BillView()
                {
                    Id = a.Id,
                    CustomerId = a.CustomerId,
                    BillStatusId = a.BillStatusId,
                    PaymentId = a.PaymentId,
                    Price = a.Price,
                    CreateDate = a.CreateDate,
                    Address = a.Address,
                    CustomerName = a.CustomerName,
                    CustomerPhone = a.CustomerPhone,
                    Customer = c,
                    BillStatus = b,
                    Payment = d
                }).FirstAsync();
            return billViews;
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
            b.CustomerName = bill.CustomerName;
            b.CustomerPhone = bill.CustomerPhone;
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
