﻿using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.ShaftViewModels;
using Datn_Shared.ViewModels.TipViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Datn_Api.Services
{
    public class TipService : ITipService
    {
         private readonly MyDbContext _db;
        public TipService(MyDbContext myDbContext)
        {
                _db = myDbContext;
        }
        public async Task<bool> CreateTip(CreateTip tip)
        {
            Tip tipModel = new Tip()
            {
                Id = Guid.NewGuid(),
                Name = tip.Name,
                Price = tip.Price,
                Size = tip.Size,
                Length = tip.Length,
                Material = tip.Material,
                Color =tip.Color,
                Status = tip.Status,

            };
            try
            {
                await _db.Tips.AddAsync(tipModel);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> DeleteTip(Guid id)
        {
            var t = await _db.Tips.FindAsync(id);
            if (t == null) return false;
          
            try
            {
                t.Status = 2;
                _db.Tips.Update(t);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public async Task<IEnumerable<Tip>> GetAllTip()
        {
            return await _db.Tips.ToListAsync(); 
        }

        public async Task<IEnumerable<Tip>> GetAllTipById(Guid id)
        {
            return await _db.Tips.Where(p=>p.Id == id).ToListAsync();
        }

        public async Task<IEnumerable<Tip>> GetAllTipByProductDetailId(Guid id)
        {
            var productDetail = await _db.ProductDetails.FirstOrDefaultAsync(p => p.Id == id);
            var productDetails = await _db.ProductDetails.Where(p => p.ProductID == productDetail.ProductID).ToListAsync();
            List<Tip> tips = new List<Tip>();
            foreach (var item in productDetails)
            {
                var tip = await _db.Tips.FirstOrDefaultAsync(p => p.Id == item.TipId);
                if (!tips.Contains(tip))
                    tips.Add(tip);
            }
            return tips;
        }

        public async Task<Tip> GetTipById(Guid id)
        {
            return await _db.Tips.FindAsync(id);
        } 

        public async Task<bool> UpdateTip(Guid id, UpdateTip tip)
        {
            var t = await _db.Tips.FindAsync(id);
            if (t == null) return false;
            t.Name = tip.Name;
            t.Price = tip.Price;
            t.Size = tip.Size;
            t.Length = tip.Length;
            t.Material = tip.Material;
            t.Color = tip.Color;
            t.Status = tip.Status;
            try
            {
                _db.Tips.Update(t);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
