using Datn_Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.ProductDetailViewModels
{
    public class ViewProductDetail
    {
        public Guid Id { get; set; }
        public Guid ProductID { get; set; }
        public Guid ShaftId { get; set; }
        public Guid WeightId { get; set; }
        public Guid TipId { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập quantity")]
        public string Quantity { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Importprice")]
        public double ImportPrice { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập price")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập createdate")]
        public DateTime CreateDate { get; set; }

        public int Status { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập description")]
        public string Description { get; set; }
        public  Product Product { get; set; }
        public  Tip Tip { get; set; }
        public  Shaft Shaft { get; set; }
        public  Weight Weight { get; set; }
    }
}
