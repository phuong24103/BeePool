using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.PaymentViewModels
{
    public class UpdatePayment
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên")]
        public string? Name { get; set; }
    }
}
