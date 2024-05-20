using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebshopBackend.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Address { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Surname { get; set; } = string.Empty;

        public decimal PhoneNumber { get; set; }

        public int? OrderId { get; set; }

        public virtual Order? Order { get; set; }

        public virtual ICollection<UserProduct> UserProducts {get; set; } = new List<UserProduct>();

        public virtual ICollection<Address> Addresses {get; set; } = new List<Address>();
    }
}