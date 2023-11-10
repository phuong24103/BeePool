using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public class ProductDetail        
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("ProductID")]
        public Guid ProductID { get; set; }
        [ForeignKey("ShaftId")]
        public Guid ShaftId { get; set; }
        [ForeignKey("WeightId")]
        public Guid WeightId { get; set; }
        [ForeignKey("TipId")]
        public Guid TipId { get; set; }
        public int Quantity { get; set; }
        public double ImportPrice{ get; set; }
        public double Price { get; set; }
        public DateTime CreateDate { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public virtual Product? Product { get; set; }
        public virtual Tip? Tip { get; set; }
        public virtual Shaft? Shaft { get; set; }
        public virtual Weight? Weight { get; set; } 
        public virtual ICollection<ProductImage>? ProductImages { get; set; }
        public  virtual ICollection<CartDetail>? CartDetails { get; set; }
        public virtual ICollection<BillDetail>? BillDetails { get; set; }
    }
}
