using Datn_Shared.Models;
using Datn_Shared.ViewModels.TipViewModels;
using Datn_Shared.ViewModels.WeightViewModels;

namespace Datn_Api.IServices
{
    public interface IWeightService
    {
        public Task<bool> CreateWeight(CreateWeight createWeight);

        public Task<bool> UpdateWeight(Guid id, UpdateWeight updateWeight);

        public Task<bool> DeleteWeight(Guid id);

        public Task<Weight> GetWeightById(Guid id);

        public Task<IEnumerable<Weight>> GetAllWeight();
        public Task<IEnumerable<Weight>> GetAllWeightById(Guid id);
    }
}
