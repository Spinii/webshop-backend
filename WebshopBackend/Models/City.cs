using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebshopBackend.Models
{
    public class City
    {
        public string CityId { get; set; } = string.Empty;

        public int PostCode { get; set; }

        public string CityName { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}