using Datn_Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.CustomerViewModels
{
	public class CustomerView
	{
		public Customer Customer { get; set; }
		public Rank Rank { get; set; }
		public Cart Cart { get; set; }
	}
}
