using Datn_Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.TipViewModels
{
    public class UpdateTip
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập ten")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập gia")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập size")]
        public int Size { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập length")]
        public int Length { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Mateial")]
        public string Material { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập color")]
        public string Color { get; set; }

        public int Status { get; set; }
    }
}
