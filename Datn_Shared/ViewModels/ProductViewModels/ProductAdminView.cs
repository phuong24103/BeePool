using Datn_Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.ProductViewModels
{
    public class ProductAdminView
    {
        public Guid Id { get; set; }
        public Guid? ProductDetailId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string? Image { get; set; }
        public int AvailableQuantity { get; set; }
        public double Revenue { get; set; }
    }
}
