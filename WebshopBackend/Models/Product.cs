using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebshopBackend.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public decimal Rating { get; set; }

        public string Thumbnail { get; set; } = string.Empty;

        public int Quantity { get; set; }

        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; }

        public string? CategoryName => Category?.Name;

        public virtual ICollection<Picture> Pictures { get; set; } = new List<Picture>();

        public virtual ICollection<UserProduct> UserProducts {get; set; } = new List<UserProduct>();
    }
}