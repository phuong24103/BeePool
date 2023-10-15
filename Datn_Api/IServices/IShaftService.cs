using Datn_Shared.Models;
using Datn_Shared.ViewModels.ShaftViewModels;
using Datn_Shared.ViewModels.TipViewModels;

namespace Datn_Api.IServices
{
    public interface IShaftService
    {
        public Task<bool> CreateShaft(CreateShaft createShaft);

        public Task<bool> UpdateShaft(Guid id, UpdateShaft updateShaft);

        public Task<bool> DeleteShaft(Guid id);

        public Task<Shaft> GetShaftById(Guid id);

        public Task<IEnumerable<Shaft>> GetAllShaft();
        public Task<IEnumerable<Shaft>> GetAllShaftById(Guid id);
    }
}
