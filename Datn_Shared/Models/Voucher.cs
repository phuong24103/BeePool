using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public  class Voucher
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("EmPloyeeId")]
        public Guid EmPloyeeId { get; set; }
        public string Code { get; set; }
        public double Value { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public int Status { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<UsedVoucher> UsedVouchers { get; set; }
    }
}
