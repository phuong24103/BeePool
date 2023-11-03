using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Datn_Shared.Models
{
    public class Customer : IdentityUser<Guid>
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("RankId")]
        public Guid RankId { get; set; }
        public string FullName { get; set; }
        public string Image { get; set; }
        public int Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreateDate { get; set; }
        public string Address { get; set; }
        public int Point { get; set; }
        public int Status { get; set; }
        public virtual Rank Rank { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual ICollection<WishList> WishLists { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
