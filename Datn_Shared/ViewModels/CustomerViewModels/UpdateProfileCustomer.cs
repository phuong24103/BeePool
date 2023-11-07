using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.CustomerViewModels
{
    public class UpdateProfileCustomer
    {
        [Required(ErrorMessage = "Vui lòng nhập Họ tên")]
        public string? FullName { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn Giới tính")]
        public int Gender { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Ngày sinh")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Địa chỉ")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Số điện thoại")]
        [MaxLength(10)]
        [RegularExpression(@"\d*[0-9]\d*", ErrorMessage = "Số điện thoại chỉ được nhập số")]
        public string? PhoneNumber { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Email")]
        public string? Email { get; set; }
    }
}
