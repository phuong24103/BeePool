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
    public class UpdateProductDetail
    {
        public Guid Id { get; set; }
        [ForeignKey("ProductID")]
        public Guid ProductID { get; set; }
        [ForeignKey("ShaftId")]
        public Guid ShaftId { get; set; }
        [ForeignKey("WeightId")]
        public Guid WeightId { get; set; }
        [ForeignKey("TipId")]
        public Guid TipId { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập quantity")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập importprice")]
        public double ImportPrice { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Price")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập ")]
        public DateTime CreateDate { get; set; }
        public int Status { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập ")]
        public string Description { get; set; }
        public List<string> Image { get; set; }
    }
}
