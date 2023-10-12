using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public class CartDetail
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("CustomerId")]
        public Guid CustomerId { get; set; }
        [ForeignKey ("ProductDetailsId")]
        public Guid ProductDetailsId { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
