using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.AccountViewModels
{
    public class Login
    {
        [Required(ErrorMessage = "Không được để trống Tài khoản")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Không được để trống Mật khẩu")]
		[DataType(DataType.Password)]
		public string? Password { get; set; }
    }
}
