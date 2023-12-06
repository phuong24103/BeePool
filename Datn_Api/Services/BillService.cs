using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.BillViewModels;
using Datn_Shared.ViewModels.ProductViewModels;
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

        public async Task<IEnumerable<BillView>> GetBillByBillStatusId(Guid id)
        {
            List<BillView> billViews = new List<BillView>();
            billViews = await(
                from a in _context.Bills
                join b in _context.BillStatuses on a.BillStatusId equals b.Id
                join c in _context.Customers on a.CustomerId equals c.Id
                join d in _context.Payments on a.PaymentId equals d.Id
                where a.BillStatusId == id
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
            billViews = await (
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

        public async Task<IEnumerable<BillView>> GetBillByCustomerIdAndBillStatusId(Guid idcustomer, Guid idbillstatus)
        {
            List<BillView> billViews = new List<BillView>();
            billViews = await (
                from a in _context.Bills
                join b in _context.BillStatuses on a.BillStatusId equals b.Id
                join c in _context.Customers on a.CustomerId equals c.Id
                join d in _context.Payments on a.PaymentId equals d.Id
                where a.CustomerId == idcustomer && a.BillStatusId == idbillstatus
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

        public async Task<IEnumerable<BillAdminView>> GetRecentSales()
        {
            var bills = await _context.Bills.Include(p => p.BillStatus).ToListAsync();
            int STT = 1;

            List<BillAdminView> billView = new List<BillAdminView>();
            if (bills != null)
            {
                foreach (var bill in bills)
                {
                    var status = await _context.BillStatuses.Where(p => p.Id == bill.BillStatusId).FirstOrDefaultAsync();
                    if (status.Name != "Chờ xác nhận")
                    {
                        var billDetail = await _context.BillDetails.Where(p => p.BillId == bill.Id).FirstOrDefaultAsync();
                        var productDetail = await _context.ProductDetails.Where(p => p.Id == billDetail.ProductDetailId).FirstOrDefaultAsync();
                        var productName = (await _context.Products.Where(p => p.Id == productDetail.ProductID).FirstOrDefaultAsync() != null) ? (await _context.Products.Where(p => p.Id == productDetail.ProductID).FirstOrDefaultAsync()).Name : "";

                        billView.Add(new BillAdminView
                        {
                            Id = bill.Id,
                            STT = STT,
                            BillStatusId = bill.BillStatusId,
                            CustomerName = bill.CustomerName,
                            ProductName = productName,
                            Price = bill.Price,
                            Status = status.Name,
                        });
                        STT++;
                    }
                }
            }
            return billView;
        }

        public async Task<IEnumerable<BillAdminView>> GetRecentSales(string date)
        {
            if (date == "today")
            {
                var a = await _context.Bills.Where(p => p.CreateDate.DayOfYear == DateTime.Now.DayOfYear).Include(p => p.BillStatus).ToListAsync();
                int a1 = 1;

                List<BillAdminView> a2 = new List<BillAdminView>();
                if (a != null)
                {
                    foreach (var bill in a)
                    {
                        var status = await _context.BillStatuses.Where(p => p.Id == bill.BillStatusId).FirstOrDefaultAsync();
                        if (status.Name != "Chờ xác nhận")
                        {
                            var billDetail = await _context.BillDetails.Where(p => p.BillId == bill.Id).FirstOrDefaultAsync();
                            var productDetail = await _context.ProductDetails.Where(p => p.Id == billDetail.ProductDetailId).FirstOrDefaultAsync();
                            var productName = (await _context.Products.Where(p => p.Id == productDetail.ProductID).FirstOrDefaultAsync() != null) ? (await _context.Products.Where(p => p.Id == productDetail.ProductID).FirstOrDefaultAsync()).Name : "";

                            a2.Add(new BillAdminView
                            {
                                Id = bill.Id,
                                STT = a1,
                                BillStatusId = bill.BillStatusId,
                                CustomerName = bill.CustomerName,
                                ProductName = productName,
                                Price = bill.Price,
                                Status = status.Name,
                            });
                            a1++;
                        }
                    }
                }
                return a2;
            }
            else if(date == "thisYear")
            {
                var b = await _context.Bills.Where(p => p.CreateDate.Year == DateTime.Now.Year).Include(p => p.BillStatus).ToListAsync();
                int b1 = 1;

                List<BillAdminView> b2 = new List<BillAdminView>();
                if (b != null)
                {
                    foreach (var bill in b)
                    {
                        var status = await _context.BillStatuses.Where(p => p.Id == bill.BillStatusId).FirstOrDefaultAsync();
                        if (status.Name != "Chờ xác nhận")
                        {
                            var billDetail = await _context.BillDetails.Where(p => p.BillId == bill.Id).FirstOrDefaultAsync();
                            var productDetail = await _context.ProductDetails.Where(p => p.Id == billDetail.ProductDetailId).FirstOrDefaultAsync();
                            var productName = (await _context.Products.Where(p => p.Id == productDetail.ProductID).FirstOrDefaultAsync() != null) ? (await _context.Products.Where(p => p.Id == productDetail.ProductID).FirstOrDefaultAsync()).Name : "";

                            b2.Add(new BillAdminView
                            {
                                Id = bill.Id,
                                STT = b1,
                                BillStatusId = bill.BillStatusId,
                                CustomerName = bill.CustomerName,
                                ProductName = productName,
                                Price = bill.Price,
                                Status = status.Name,
                            });
                            b1++;
                        }
                    }
                }
                return b2;
            }
            else if(date == "thisMonth")
            {
                var c = await _context.Bills.Where(p => p.CreateDate.Year == DateTime.Now.Year && p.CreateDate.Month == DateTime.Now.Month).Include(p => p.BillStatus).ToListAsync();
                int c1 = 1;

                List<BillAdminView> c2 = new List<BillAdminView>();
                if (c != null)
                {
                    foreach (var bill in c)
                    {
                        var status = await _context.BillStatuses.Where(p => p.Id == bill.BillStatusId).FirstOrDefaultAsync();
                        if (status.Name != "Chờ xác nhận")
                        {
                            var billDetail = await _context.BillDetails.Where(p => p.BillId == bill.Id).FirstOrDefaultAsync();
                            var productDetail = await _context.ProductDetails.Where(p => p.Id == billDetail.ProductDetailId).FirstOrDefaultAsync();
                            var productName = (await _context.Products.Where(p => p.Id == productDetail.ProductID).FirstOrDefaultAsync() != null) ? (await _context.Products.Where(p => p.Id == productDetail.ProductID).FirstOrDefaultAsync()).Name : "";

                            c2.Add(new BillAdminView
                            {
                                Id = bill.Id,
                                STT = c1,
                                BillStatusId = bill.BillStatusId,
                                CustomerName = bill.CustomerName,
                                ProductName = productName,
                                Price = bill.Price,
                                Status = status.Name,
                            });
                            c1++;
                        }
                    }
                }
                return c2;
            }
            var bills = await _context.Bills.Include(p => p.BillStatus).ToListAsync();
            int STT = 1;

            List<BillAdminView> billView = new List<BillAdminView>();
            if (bills != null)
            {
                foreach (var bill in bills)
                {
                    var status = await _context.BillStatuses.Where(p => p.Id == bill.BillStatusId).FirstOrDefaultAsync();
                    if (status.Name != "Chờ xác nhận")
                    {
                        var billDetail = await _context.BillDetails.Where(p => p.BillId == bill.Id).FirstOrDefaultAsync();
                        var productDetail = await _context.ProductDetails.Where(p => p.Id == billDetail.ProductDetailId).FirstOrDefaultAsync();
                        var productName = (await _context.Products.Where(p => p.Id == productDetail.ProductID).FirstOrDefaultAsync() != null) ? (await _context.Products.Where(p => p.Id == productDetail.ProductID).FirstOrDefaultAsync()).Name : "";

                        billView.Add(new BillAdminView
                        {
                            Id = bill.Id,
                            STT = STT,
                            BillStatusId = bill.BillStatusId,
                            CustomerName = bill.CustomerName,
                            ProductName = productName,
                            Price = bill.Price,
                            Status = status.Name,
                        });
                        STT++;
                    }
                }
            }
            return billView;
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
