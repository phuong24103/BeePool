﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public class Bill
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("CustomerId")]
        public Guid CustomerId { get; set; }
        [ForeignKey("BillStatusId")]
        public Guid BillStatusId { get; set; }
        [ForeignKey("PaymentId")]
        public Guid PaymentId { get; set; }
        public double Price { get; set; }
        public DateTime CreateDate { get; set; }
        public string Address { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual UsedVoucher? UsedVoucher { get; set; }
        public virtual BillStatus? BillStatus { get; set; }
        public virtual Payment? Payment { get; set; }
        public virtual ICollection<BillDetail>? BillDetails { get; set; }
    }
}
