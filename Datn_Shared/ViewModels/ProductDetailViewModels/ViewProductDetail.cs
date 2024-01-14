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
        public int Quantity { get; set; }
        public double ImportPrice { get; set; }
        public double Price { get; set; }
        public DateTime CreateDate { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public List<string> Image { get; set; }
        public  Product Product { get; set; }
        public  Tip Tip { get; set; }
        public  Shaft Shaft { get; set; }
        public  Weight Weight { get; set; }
    }
}
