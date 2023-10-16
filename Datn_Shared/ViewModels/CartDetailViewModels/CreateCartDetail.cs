using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.CartDetailViewModels
{
    public class CreateCartDetail
    {
        public Guid CustomerId { get; set; }
        public Guid ProductDetailId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
