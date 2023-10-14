using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.WeightViewModels
{
    public class UpdateWeight
    {
        [Required(ErrorMessage = "Vui lòng nhập name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập price")]
        public double Price { get; set; }


        public int Status { get; set; }
    }
}
