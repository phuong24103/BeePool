using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.BillDetailViewModels
{
    public class UpdateBillDetail
    {
        public Guid Id { get; set; }
        public Guid BillId { get; set; }
        public Guid ProductDetailId { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số lượng")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập giá")]
        public double Price { get; set; }
    }
}
