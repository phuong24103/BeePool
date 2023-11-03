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
        [Required(ErrorMessage = "Không được để trống Họ tên")]
        public string? FullName { get; set; }
        [Required(ErrorMessage = "Không được để trống Tên đăng nhập")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Không được để trống Mật khẩu")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Không được để trống Mật khẩu xác nhận")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn Giới tính")]
        public int? Gender { get; set; }
        [MaxLength(10)]
        [RegularExpression(@"\d*[0-9]\d*", ErrorMessage = "Số điện thoại chỉ được nhập số")]
        public string? PhoneNumber { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Không được để trống Email")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Không được để trống Ngày sinh")]
        public DateTime? DateOfBirth { get; set; }
        [Required(ErrorMessage = "Không được để trống Địa chỉ")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn Ảnh")]
        public string? Image { get; set; }
    }
}
