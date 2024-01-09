using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.BrandViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class BrandService : IBrandServices
    {
        private readonly MyDbContext _context;

        public BrandService(MyDbContext myDbContext)
        {
                _context = myDbContext;
        }
        public async Task<bool> CreateBrand(CreateBrand brand)
        {
          Brand b = new Brand() {
              Id = Guid.NewGuid(),
              Name = brand.Name,
              DateCreated = DateTime.Now,
              Status = 0,
              Description = brand.Description,
          };
            try
            {
                await _context.Brands.AddAsync(b);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> DeleteBrand(Guid id)
        {
            var brand = _context.Brands.Find(id);
            if (brand == null) return false;
            try
            {
                brand.Status = 2;
                _context.Brands.Update(brand);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Brand>> GetAllBrand()
        {
            return await _context.Brands.Where(p => p.Status != 2).ToListAsync();
        }

        public async Task<Brand> GetBrandById(Guid id)
        {
            return await _context.Brands.Where(p => p.Status != 2 && p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Brand>> GetBrandByName(string name)
        {
            return await _context.Brands.Where(p => p.Status != 2 && p.Name.ToLower().Contains(name.ToLower())).ToListAsync();
        }

        public async Task<bool> UpdateBrand(Guid id, UpdateBrand brand)
        {
            try
            {
                var n = _context.Brands.Find(id);
                if (n == null) return false;
                n.Name = brand.Name;
                n.Description = brand.Description;
                n.Status = 1;
                _context.Brands.Update(n);
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
