using Datn_Shared.Models;
using Datn_Shared.ViewModels.BillViewModels;

namespace Datn_Api.IServices
{
    public interface IBillService
    {
        public Task<bool> CreateBill(CreateBill bill);
        public Task<bool> UpdateBill(Guid id, UpdateBill bill);
        public Task<bool> DeleteBill(Guid id);
        public Task<BillView> GetBillById(Guid id);
        public Task<IEnumerable<BillView>> GetBillByCustomerId(Guid id);
        public Task<IEnumerable<BillView>> GetAllBills();
        public Task<IEnumerable<BillAdminView>> GetRecentSales();
        public Task<IEnumerable<BillAdminView>> GetRecentSales(string date);
        public Task<IEnumerable<BillView>> GetBillByCustomerIdAndBillStatusId(Guid idcustomer, Guid idbillstatus);
        public Task<IEnumerable<BillView>> GetBillByBillStatusId(Guid id);
    }
}
