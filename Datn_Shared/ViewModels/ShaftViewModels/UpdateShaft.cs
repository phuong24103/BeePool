using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.ShaftViewModels
{
    public class UpdateShaft
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập price")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập size")]
        public double Size { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập length")]
        public int Length { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập material")]
        public string Material { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập color")]
        public string Color { get; set; }

        public int Status { get; set; }
    }
}
