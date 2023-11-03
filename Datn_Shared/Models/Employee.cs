using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public class Employee : IdentityUser<Guid>
    {
        [Key]
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Image { get; set; }
        public int Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address{ get; set;}
        public string? Twitter { get; set;}
        public string? Facebook { get; set;}
        public string? Instagram { get; set;}
        public string? Linkedin { get; set;}
        public DateTime CreateDate { get; set;}
        public int Status{ get; set;}
        public virtual ICollection<Voucher>? Vouchers { get; set;}

    }
}
