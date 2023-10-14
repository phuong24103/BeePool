using Datn_Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.ProductViewModels
{
    public class ProductView
    {
        public Guid Id { get; set; }
        public Guid CategoryID { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public string Pin { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public string Wrap { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public string Rings { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public double ImportPrice { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public int AvailableQuantity { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public int Sold { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public int Likes { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public DateTime CreateDate { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public string Producer { get; set; }

        public int Status { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public string Description { get; set; }
    }
}
