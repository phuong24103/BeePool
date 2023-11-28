using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Api.Migrations;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.BillDetailViewModels;
using Datn_Shared.ViewModels.BillViewModels;
using Microsoft.EntityFrameworkCore;
using System;

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
                ProductDetailId = billDetail.ProductDetailId,
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

        public async Task<IEnumerable<BillDetailView>> GetAllBillDetails()
        {
            List<BillDetailView> billDetailViews = new List<BillDetailView>();
            billDetailViews = await (
                from a in _context.BillDetails
                join b in _context.Bills on a.BillId equals b.Id
                join c in _context.ProductDetails on a.ProductDetailId equals c.Id
                select new BillDetailView()
                {
                    Id = a.Id,
                    BillId = a.BillId,
                    ProductDetailId = a.ProductDetailId,
                    Quantity = a.Quantity,
                    Price = a.Price,
                    Bill = b,
                    ProductDetailt = c
                }).ToListAsync();
            return billDetailViews;
        }

        public async Task<BillDetailView> GetBillDetailsById(Guid id)
        {
            BillDetailView billDetailViews = new BillDetailView();
            billDetailViews = await (
                from a in _context.BillDetails
                join b in _context.Bills on a.BillId equals b.Id
                join c in _context.ProductDetails on a.ProductDetailId equals c.Id
                join d in _context.Products on c.ProductID equals d.Id
                where a.Id == id
                select new BillDetailView()
                {
                    Id = a.Id,
                    BillId = a.BillId,
                    ProductDetailId = a.ProductDetailId,
                    ProductName = d.Name,
                    Quantity = a.Quantity,
                    Price = a.Price,
                    Bill = b,
                    ProductDetailt = c
                }).FirstAsync();
            return billDetailViews;
        }

        public async Task<IEnumerable<BillDetailView>> GetBillDetailsByIdBill(Guid id)
        {
            List<BillDetailView> billDetailViews = new List<BillDetailView>();
            billDetailViews = await (
                from a in _context.BillDetails
                join b in _context.Bills on a.BillId equals b.Id
                join c in _context.ProductDetails on a.ProductDetailId equals c.Id
                join d in _context.Products on c.ProductID equals d.Id
                where a.BillId == id
                select new BillDetailView()
                {
                    Id = a.Id,
                    BillId = a.BillId,
                    ProductDetailId = a.ProductDetailId,
                    ProductName = d.Name,
                    Quantity = a.Quantity,
                    Price = a.Price,
                    Bill = b,
                    ProductDetailt = c
                }).ToListAsync();
            return billDetailViews;
        }

        public async Task<string> GetReportRevenue()
        {
            var billDetail = await _context.BillDetails.ToListAsync();
            if (billDetail != null)
            {
                string revenue = "";
                for (int i = 0; i < billDetail.Count; i++)
                {
                    revenue += $"'{billDetail[i].Price}'";

                    if (i < billDetail.Count - 1)
                    {
                        revenue += ", ";
                    }
                }
                return revenue;
            }
            return "";
        }

        public async Task<string> GetReportSales()
        {
            var billDetail = await _context.BillDetails.ToListAsync();
            if (billDetail != null)
            {
                string sales = "";
                for (int i = 0; i < billDetail.Count; i++)
                {
                    sales += $"'{billDetail[i].Quantity}'";

                    if (i < billDetail.Count - 1)
                    {
                        sales += ", ";
                    }
                }
                return sales;
            }
            return "";
        }

        public async Task<double> GetRevenue()
        {
            var billDetail = await _context.BillDetails.ToListAsync();
            if (billDetail != null)
            {
                double revenue = 0;
                foreach (var b in billDetail)
                {
                    revenue += b.Price;
                }
                return revenue;
            }
            return 0;
        }

        public async Task<double> GetRevenueFilter(string date)
        {
            var billDetail = await _context.BillDetails.ToListAsync();
            if (billDetail != null)
            {
                double revenue = 0;
                foreach (var b in billDetail)
                {
                    var bill = await _context.Bills.Where(p => p.Id == b.BillId).FirstOrDefaultAsync();
                    if (date == "today")
                    {
                        if (bill.CreateDate.DayOfYear == DateTime.Now.DayOfYear)
                        {
                            revenue += b.Price;
                        }
                    }
                    else if (date == "thisYear")
                    {
                        if (bill.CreateDate.Year == DateTime.Now.Year)
                        {
                            revenue += b.Price;
                        }
                    }
                    else if (date == "thisMonth")
                    {
                        if (bill.CreateDate.Year == DateTime.Now.Year && bill.CreateDate.Month == DateTime.Now.Month)
                        {
                            revenue += b.Price;
                        }
                    }
                    else
                    {
                        revenue += b.Price;
                    }
                }
                return revenue;
            }
            return 0;
        }

        public async Task<int> GetSales()
        {
            var billDetail = await _context.BillDetails.ToListAsync();
            if (billDetail != null)
            {
                int sales = 0;
                foreach (var b in billDetail)
                {
                    sales += b.Quantity;
                }
                return sales;
            }
            return 0;
        }

        public async Task<int> GetSalesFilter(string date)
        {
            var billDetail = await _context.BillDetails.ToListAsync();
            if (billDetail != null)
            {
                int sales = 0;
                foreach (var b in billDetail)
                {
                    var bill = await _context.Bills.Where(p => p.Id == b.BillId).FirstOrDefaultAsync();
                    if (date == "today")
                    {
                        if (bill.CreateDate.DayOfYear == DateTime.Now.DayOfYear)
                        {
                            sales += b.Quantity;
                        }
                    }
                    else if (date == "thisYear")
                    {
                        if (bill.CreateDate.Year == DateTime.Now.Year)
                        {
                            sales += b.Quantity;
                        }
                    }
                    else if (date == "thisMonth")
                    {
                        if (bill.CreateDate.Year == DateTime.Now.Year && bill.CreateDate.Month == DateTime.Now.Month)
                        {
                            sales += b.Quantity;
                        }
                    }
                    else
                    {
                        sales += b.Quantity;
                    }
                }
                return sales;
            }
            return 0;
        }

        public async Task<bool> UpdateBillDetails(Guid id, UpdateBillDetail billDetail)
        {
            var b = _context.BillDetails.Find(id);
            if (b == null) return false;
            b.BillId = billDetail.BillId;
            b.ProductDetailId = billDetail.ProductDetailId;
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
