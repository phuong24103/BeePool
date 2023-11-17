using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("CategoryID")]
        public Guid CategoryID { get; set; }
        public string Name { get; set; }
        public string Pin {  get; set; }
        public string Wrap {  get; set; }
        public string Rings {  get; set; }
        public int AvailableQuantity { get; set; }
        public int Sold {  get; set; }
        public int Likes { get; set; }
        public string Producer { get; set; }
        public DateTime CreateDate { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ICollection <WishList>? WishLists { get; set; }
        public virtual ICollection<ProductDetail>? ProductDetails { get; set; }


    }
}
