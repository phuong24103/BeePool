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
        public string Description { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
