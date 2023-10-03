using Datn_Shared.Models;
using Datn_Shared.ViewModels.VoucherViewModels;

namespace Datn_Api.IServices
{
    public interface IVoucherService
    {
        public Task<bool> CreateVoucher(CreateVoucher voucher);
        public Task<bool> UpdateVoucher(Guid id, UpdateVoucher voucher);
        public Task<bool> DeleteVoucher(Guid id);
        public Task<Voucher> GetVoucherById(Guid id);
        public Task<IEnumerable<Voucher>> GetAllVoucher();
    }
}
