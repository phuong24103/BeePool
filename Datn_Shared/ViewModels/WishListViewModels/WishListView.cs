using Datn_Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.WishListViewModels
{
    public class WishListView
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }
        public Guid ProductDetailId { get; set; }
        public double Price { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}
