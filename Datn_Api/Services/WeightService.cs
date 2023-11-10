using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.ShaftViewModels;
using Datn_Shared.ViewModels.WeightViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class WeightService : IWeightService
    {
        private readonly MyDbContext _context;
        public WeightService(MyDbContext myDbContext)
        {
                _context = myDbContext;
        }
        public async Task<bool> CreateWeight(CreateWeight createWeight)
        {
            Weight p = new Weight()
            {
                Id = Guid.NewGuid(),
                Name = createWeight.Name,
                Price = createWeight.Price,
                Status = createWeight.Status,
            };
            try
            {
                await _context.Weights.AddAsync(p);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteWeight(Guid id)
        {
            var t = await _context.Weights.FindAsync(id);
            if (t == null) return false;

            try
            {
                t.Status = 2;
                _context.Weights.Update(t);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<IEnumerable<Weight>> GetAllWeight()
        {
            return await _context.Weights.ToListAsync();
        }

        public async Task<IEnumerable<Weight>> GetAllWeightById(Guid id)
        {
            return await _context.Weights.Where(p=>p.Id==id).ToListAsync();
        }

        public async Task<IEnumerable<Weight>> GetAllWeightByProductDetailId(Guid id)
        {
            var productDetail = await _context.ProductDetails.FirstOrDefaultAsync(p => p.Id == id);
            var productDetails = await _context.ProductDetails.Where(p => p.ProductID == productDetail.ProductID).ToListAsync();
            List<Weight> weights = new List<Weight>();
            foreach (var item in productDetails)
            {
                var weight = await _context.Weights.FirstOrDefaultAsync(p => p.Id == item.WeightId);
                if (!weights.Contains(weight))
                    weights.Add(weight);
            }
            return weights;
        }

        public async Task<Weight> GetWeightById(Guid id)
        {
            return await _context.Weights.FindAsync(id);
        }

        public async Task<bool> UpdateWeight(Guid id, UpdateWeight updateWeight)
        {
            var t = await _context.Weights.FindAsync(id);
            if (t == null) return false;
            t.Name = updateWeight.Name;
            t.Price = updateWeight.Price;
            t.Status = updateWeight.Status;
            try
            {
                _context.Weights.Update(t);
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
