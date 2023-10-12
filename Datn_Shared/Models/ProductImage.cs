using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public class ProductImage
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("ProductDetailId")]
        public Guid ProductDetailId { get; set; }
        public string Name { get; set; } 
        public int Status { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }
    }
}
