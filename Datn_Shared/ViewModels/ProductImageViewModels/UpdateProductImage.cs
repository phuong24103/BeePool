using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.ProductImageViewModels
{
    public class UpdateProductImage
    {
        public Guid ProductDetailId { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập name")]
        public string Name { get; set; }
        public int Status { get; set; }
    }
}
