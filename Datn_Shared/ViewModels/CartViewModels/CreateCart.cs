using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.CartViewModels
{
    public class CreateCart
    {
        public Guid CustomerId { get; set; }
        public int Quantity { get; set; }
        public double TotalMoney { get; set; }
        public int Status { get; set; }
    }
}