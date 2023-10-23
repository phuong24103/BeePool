using Datn_Shared.Models;
using Datn_Shared.ViewModels.BillDetailViewModels;

namespace Datn_Api.IServices
{
    public interface IBillDetailService
    {
        public Task<bool> CreateBillDetails(CreateBillDetail billDetail);
        public Task<bool> UpdateBillDetails(Guid id, UpdateBillDetail billDetail);
        public Task<bool> DeleteBillDetails(Guid id);
        public Task<BillDetailView> GetBillDetailsById(Guid id);
        public Task<IEnumerable<BillDetailView>> GetBillDetailsByIdBill(Guid id);
        public Task<IEnumerable<BillDetailView>> GetAllBillDetails();
    }
}
