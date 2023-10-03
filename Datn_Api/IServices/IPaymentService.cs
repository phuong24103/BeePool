using Datn_Shared.Models;
using Datn_Shared.ViewModels.PaymentViewModels;

namespace Datn_Api.IServices
{
    public interface IPaymentService
    {
        public Task<bool> CreatePayment(CreatePayment payment);
        public Task<bool> UpdatePayment(Guid id, UpdatePayment payment);
        public Task<bool> DeletePayment(Guid id);
        public Task<Payment> GetPaymentById(Guid id);
        public Task<IEnumerable<Payment>> GetAllPayment();
    }
}
