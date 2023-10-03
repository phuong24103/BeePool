using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.PaymentViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly MyDbContext _context;

        public PaymentService(MyDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreatePayment(CreatePayment payment)
        {
            Payment p = new Payment()
            {
                Id = Guid.NewGuid(),
                Name = payment.Name
            };
            try
            {
                await _context.Payments.AddAsync(p);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeletePayment(Guid id)
        {
            var payment = _context.Payments.Find(id);
            if (payment == null) return false;
            try
            {
                _context.Payments.Remove(payment);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<Payment>> GetAllPayment()
        {
            return await _context.Payments.ToListAsync();
        }

        public async Task<Payment> GetPaymentById(Guid id)
        {
            return await _context.Payments.FindAsync(id);
        }

        public async Task<bool> UpdatePayment(Guid id, UpdatePayment payment)
        {
            var p = _context.Payments.Find(id);
            if (p == null) return false;
            p.Name = payment.Name;
            try
            {
                _context.Payments.Update(p);
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
