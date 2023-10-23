using Datn_Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.BillDetailViewModels
{
    public class BillDetailView
    {
        public Guid Id { get; set; }
        public Guid BillId { get; set; }
        public Guid ProductDetailId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Bill Bill { get; set; }
        public ProductDetail ProductDetailt { get; set; }
    }
}
