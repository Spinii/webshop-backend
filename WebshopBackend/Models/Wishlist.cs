using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebshopBackend.Models
{
    public class Wishlist
    {
        public int WishlistId { get; set; }

        public int ProductId { get; set; }

        public int UserId { get; set; }

        public virtual User? User { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}