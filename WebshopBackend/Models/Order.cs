using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebshopBackend.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public decimal Total { get; set; }

        public decimal Tax { get; set; }

        public string PaymentOption { get; set; } = string.Empty;

        public string Jir { get; set; } = string.Empty;

        public int PaymentId { get; set; }
    }
}