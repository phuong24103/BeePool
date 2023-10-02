using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.CategoryViewModels
{
    public class UpdateCategory
    {
        [Required(ErrorMessage = "Vui lòng nhập tên")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn trạng thái")]
        public int Status { get; set; }
    }
}
