using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.BillViewModels
{
    public class UpdateBill
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid BillStatusId { get; set; }
        public Guid PaymentId { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập giá")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập ngày tạo")]
        public DateTime CreateDate { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        public string? Address { get; set; }
    }
}
