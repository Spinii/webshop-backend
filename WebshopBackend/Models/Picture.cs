using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebshopBackend.Models
{
    public class Picture
    {
        public int PictureId { get; set; }

        public string Link { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public int ProductId { get; set; }

        public virtual Product? Product { get; set; }
    }
}