using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebshopBackend.Models
{
    public class UserProduct
    {
        public int UserProductId { get; set; }

        public int ProductId { get; set; }

        public virtual User? User { get; set; }

        public virtual Product? Product {get; set; }
    }
}