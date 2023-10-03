using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.BillStatusViewModels
{
    public class CreateBillStatus
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên")]
        public string? Name { get; set; }
    }
}
