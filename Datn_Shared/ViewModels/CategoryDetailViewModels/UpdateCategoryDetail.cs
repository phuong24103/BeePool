using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.CategoryDetailViewModels
{
    public class UpdateCategoryDetail
    {
        [Required(ErrorMessage = "Vui lòng chọn danh mục")]
        public Guid CategoryId { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn sản phẩm")]
        public Guid ProductId { get; set; }
        public int QuantityProduct { get; set; }
    }
}
