using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;

namespace Datn_Api.Services
{
    public class UserVoucherService : IUserVoucherService
    {
        private readonly MyDbContext _context;
        public UserVoucherService(MyDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateUserVoucher(UsedVoucher usedVoucher)
        {
            await _context.UsedVouchers.AddAsync(usedVoucher);
            return true;
        }
    }
}
