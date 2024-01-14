using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.ProductImageViewModels
{
    public class ViewProductImage
    {
        public Guid Id { get; set; }
        public Guid ProductDetailId { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
    }
}
