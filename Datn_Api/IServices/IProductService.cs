using Datn_Shared.Models;
using Datn_Shared.ViewModels.ProductViewModels;

namespace Datn_Api.IServices
{
    public interface IProductService
    {
        public Task<bool> CreateProduct(CreateProduct product);
        public Task<bool> UpdateProduct(Guid id, UpdateProduct product);
        public Task<bool> DeleteProduct(Guid id);
        public Task<ProductView> GetProductById(Guid id);
        public Task<IEnumerable<ProductView>> GetProductByName(string name);
        public Task<IEnumerable<ProductView>> GetAllProduct();
        public Task<IEnumerable<ProductView>> GetProductByNameAZ();
        public Task<IEnumerable<ProductView>> GetProductByNameZA();
        public Task<IEnumerable<ProductView>> GetProductByCreateDateOld();
        public Task<IEnumerable<ProductView>> GetProductByCreateDateNew();
        public Task<IEnumerable<ProductView>> GetProductByPrice2();
        public Task<IEnumerable<ProductView>> GetProductByPriceMin();
        public Task<IEnumerable<ProductView>> GetProductByPriceMax();
        public Task<IEnumerable<ProductView>> GetProductByCategory(string name);
        public Task<IEnumerable<ProductAdminView>> GetProductStatistics();
        public Task<IEnumerable<ProductAdminView>> GetProductStatisticsFilter(string date);
    }
}