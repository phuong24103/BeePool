﻿using Datn_Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.BillViewModels
{
    public class BillView
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid BillStatusId { get; set; }
        public Guid PaymentId { get; set; }
        public double Price { get; set; }
        public DateTime CreateDate { get; set; }
        public string Address { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public Customer Customer { get; set; }
        public UsedVoucher UsedVoucher { get; set; }
        public BillStatus BillStatus { get; set; }
        public Payment Payment { get; set; }
    }
}
