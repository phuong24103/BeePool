using Datn_Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.CartDetailViewModels
{
    public class CartDetailView
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ProductDetailId { get; set; }
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double ProductPrice { get; set; }
        public double TotalMoney { get; set; }
        public string? Image { get; set; }
        public ProductDetail? ProductDetail { get; set; }
        public Cart? Cart { get; set; }
    }
}
