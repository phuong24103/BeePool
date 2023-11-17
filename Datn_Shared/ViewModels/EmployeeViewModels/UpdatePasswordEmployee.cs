using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.EmployeeViewModels
{
    public class UpdatePasswordEmployee
    {
        [Required(ErrorMessage = "Vui lòng nhập Mật khẩu hiện tại")]
        public string CurrentPassword { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Mật khẩu mới")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Xác nhận Mật khẩu mới")]
        [DataType(DataType.Password)]
        public string ConfirmNewPassword { get; set; }
    }
}
