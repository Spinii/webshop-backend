using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebshopBackend.Models
{
    public class Cart
    {
        public int CartId { get; set; }

        public bool Processing { get; set; }
        
        public string Status { get; set; } = string.Empty;

        public decimal Total { get; set; }

        public virtual User? User { get; set; }

        public virtual Order? Order { get; set; }

        public decimal Price { get; set; }
    }
}