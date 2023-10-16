using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.Models
{
    public  class Rank
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int NecessaryPoints {  get; set; }
        public int Status { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }

    }
}
