using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebshopBackend.Models
{
    public class Address
    {
        public int AddressId { get; set; }

        public string StreetName { get; set; } = string.Empty;

        public int StreetNumber { get; set; }

        public string DeliveryNote { get; set; } = string.Empty;

        public bool IsDelivered { get; set; }

        public int UserId { get; set; }

        public virtual User? User { get; set; }

        public string CityId { get; set; } = string.Empty;
    }
}