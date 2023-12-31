﻿using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.ShaftViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Datn_Api.Services
{
    public class ShaftService : IShaftService
    {
        private readonly MyDbContext _context;
        public ShaftService(MyDbContext myDbContext )
        {
            _context = myDbContext;
        }
        public async Task<bool> CreateShaft(CreateShaft createShaft)
        {
            Shaft p = new Shaft()
            {
                Id = Guid.NewGuid(),
                Name = createShaft.Name,
                Price = createShaft.Price,
                Size = createShaft.Size,
                Length = createShaft.Length,
                Material = createShaft.Material,
                Color = createShaft.Color,
                Status = createShaft.Status,
            };
            try
            {
                await _context.Shafts.AddAsync(p);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteShaft(Guid id)
        {
                var t = await _context.Shafts.FindAsync(id);
                if (t == null) return false;

                try
                {
                    t.Status = 2;
                     _context.Shafts.Update(t);
                    await _context.SaveChangesAsync();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
        }

        public async Task<IEnumerable<Shaft>> GetAllShaft()
        {
            return await _context.Shafts.ToListAsync();
        }

        public async Task<IEnumerable<Shaft>> GetAllShaftById(Guid id)
        {
            return await _context.Shafts.Where(p=>p.Id == id).ToListAsync();
        }

        public async Task<IEnumerable<Shaft>> GetAllShaftByProductDetailId(Guid id)
        {
            var productDetail = await _context.ProductDetails.FirstOrDefaultAsync(p => p.Id == id);
            var productDetails = await _context.ProductDetails.Where(p => p.ProductID == productDetail.ProductID).ToListAsync();
            List<Shaft> shafts = new List<Shaft>();
            foreach (var item in productDetails)
            {
                var shaft = await _context.Shafts.FirstOrDefaultAsync(p => p.Id == item.ShaftId);
                if(!shafts.Contains(shaft))
                    shafts.Add(shaft);
            }
            return shafts;
        }

        public async Task<Shaft> GetShaftById(Guid id)
        {
            return await _context.Shafts.FindAsync(id);
        }

        public async Task<bool> UpdateShaft(Guid id, UpdateShaft updateShaft)
        {
            var t = await _context.Shafts.FindAsync(id);
            if (t == null) return false;
            t.Name = updateShaft.Name;
            t.Price = updateShaft.Price;
            t.Size = updateShaft.Size;
            t.Length = updateShaft.Length;
            t.Material = updateShaft.Material;
            t.Color = updateShaft.Color;
            t.Status = updateShaft.Status;
            try
            {
                _context.Shafts.Update(t);
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
