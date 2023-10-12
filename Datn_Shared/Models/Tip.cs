using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public class Tip
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Size { get; set; }
        public int Length { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }

        public int Status { get; set; }
        public virtual ICollection <ProductDetail> ProductDetails { get; set; }
    }
}
