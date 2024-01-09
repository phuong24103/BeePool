using Datn_Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.ProductViewModels
{
    public class ProductView
    {
        public Guid Id { get; set; }
        public Guid CategoryID { get; set; }
        public Guid BrandID {  get; set; }
        public Guid? ProductDetailId { get; set; }
        public string Name { get; set; }
        public string Pin { get; set; }
        public string Wrap { get; set; }
        public string Rings { get; set; }
        public int AvailableQuantity { get; set; }
        public double Price { get; set; }
        public string? Image { get; set; }
        public int Sold { get; set; }
        public int Likes { get; set; }
        public DateTime CreateDate { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public string CategoryName {  get; set; }
        public Category?  Category { get; set; }
        public Brand?  Brand { get; set; }
    }
}
