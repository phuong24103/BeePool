using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.AccountViewModels
{
    public class Register
    {
        [Required(ErrorMessage = "Không được để trống tên đăng nhập")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Không được để trống mật khẩu")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Không được để trống mật khẩu xác nhận")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Mật khẩu xác nhận không trùng khớp.")]
        public string? ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn giới tính")]
        public int? Gender { get; set; }
        [MaxLength(10)]
        [RegularExpression(@"\d*[0-9]\d*", ErrorMessage = "PhoneNumber chỉ được nhập số")]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Không được để trống Email")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Không được để trống ngày sinh")]
        public DateTime? DateOfBirth { get; set; }
        [Required(ErrorMessage = "Không được để trống địa chỉ")]
        public string? Address { get; set; }
    }
}
