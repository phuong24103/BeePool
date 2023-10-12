using Datn_Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.VoucherViewModels
{
    public class CreateVoucher
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập code")]
        public string? Code { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập giá trị")]
        public double Value { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thời gian bắt đầu")]
        public DateTime TimeStart { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thời gian kết thúc")]
        public DateTime TimeEnd { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trạng thái")]
        public int Status { get; set; }
    }
}
