using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.BillStatusViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Datn_Api.Services
{
    public class BillStatusService : IBillStatusService
    {
        private readonly MyDbContext _context;

        public BillStatusService(MyDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateBillStatus(CreateBillStatus billStatus)
        {
            BillStatus bs = new BillStatus()
            {
                Id = Guid.NewGuid(),
                Name = billStatus.Name
            };
            try
            {
                await _context.BillStatuses.AddAsync(bs);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteBillStatus(Guid id)
        {
            var billStatuss = _context.BillStatuses.Find(id);
            if (billStatuss == null) return false;
            try
            {
                _context.BillStatuses.Remove(billStatuss);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<BillStatus>> GetAllBillStatus()
        {
            return await _context.BillStatuses.ToListAsync();
        }

        public async Task<BillStatus> GetBillStatusById(Guid id)
        {
            return await _context.BillStatuses.FindAsync(id);
        }

        public async Task<bool> UpdateBillStatus(Guid id, UpdateBillStatus billStatus)
        {
            var bs = _context.BillStatuses.Find(id);
            if (bs == null) return false;
            bs.Name = billStatus.Name;
            try
            {
                _context.BillStatuses.Update(bs);
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
