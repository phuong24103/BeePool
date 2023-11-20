using Datn_Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.BillViewModels
{
    public class BillAdminView
    {
        public Guid Id { get; set; }
        public Guid BillStatusId { get; set; }
        public int STT { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }
    }
}
