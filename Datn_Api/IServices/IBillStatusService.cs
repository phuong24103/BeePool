using Datn_Shared.Models;
using Datn_Shared.ViewModels.BillStatusViewModels;

namespace Datn_Api.IServices
{
    public interface IBillStatusService
    {
        public Task<bool> CreateBillStatus(CreateBillStatus billStatus);
        public Task<bool> UpdateBillStatus(Guid id, UpdateBillStatus billStatus);
        public Task<bool> DeleteBillStatus(Guid id);
        public Task<BillStatus> GetBillStatusById(Guid id);
        public Task<IEnumerable<BillStatus>> GetAllBillStatus();
    }
}
