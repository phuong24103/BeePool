using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.VoucherViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Datn_Api.Services
{
    public class VoucherService : IVoucherService
    {
        private readonly MyDbContext _context;

        public VoucherService(MyDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateVoucher(CreateVoucher voucher)
        {
            Voucher v = new Voucher()
            {
                Id = Guid.NewGuid(),
                EmPloyeeId = voucher.EmPloyeeId,
                Code = voucher.Code,
                Value = voucher.Value,
                TimeStart = voucher.TimeStart,
                TimeEnd = voucher.TimeEnd,
                Status = voucher.Status
            };
            try
            {
                await _context.Vouchers.AddAsync(v);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteVoucher(Guid id)
        {
            var voucher = _context.Vouchers.Find(id);
            if (voucher == null) return false;
            try
            {
                _context.Vouchers.Remove(voucher);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<Voucher>> GetAllVoucher()
        {
            return await _context.Vouchers.ToListAsync();
        }

        public async Task<Voucher> GetVoucherById(Guid id)
        {
            return await _context.Vouchers.FindAsync(id);
        }

        public async Task<bool> UpdateVoucher(Guid id, UpdateVoucher voucher)
        {
            var v = _context.Vouchers.Find(id);
            if (v == null) return false;
            v.EmPloyeeId = voucher.EmPloyeeId;
            v.Code = voucher.Code;
            v.Value = voucher.Value;
            v.TimeStart = voucher.TimeStart;
            v.TimeEnd = voucher.TimeEnd;
            v.Status = voucher.Status;
            try
            {
                _context.Vouchers.Update(v);
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
