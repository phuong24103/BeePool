using Datn_Shared.Models;

namespace Datn_Api.IServices
{
    public interface IUserVoucherService
    {
        public Task<bool> CreateUserVoucher(UsedVoucher usedVoucher);
    }
}
