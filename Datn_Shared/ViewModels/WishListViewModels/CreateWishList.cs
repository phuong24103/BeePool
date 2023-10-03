using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.WishListViewModels
{
    public class CreateWishList
    {
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
    }
}
