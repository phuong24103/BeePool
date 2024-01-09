using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.BrandViewModels
{
    public class UpdateBrand
    {
        [Required(ErrorMessage = "Vui lòng nhập tên")]
        public string Name { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }

    }
}
