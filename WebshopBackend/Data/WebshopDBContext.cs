using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebshopBackend.Models;

namespace WebshopBackend.Data
{
    public class WebshopDBContext : DbContext
    {
        public WebshopDBContext(DbContextOptions dbDonctextOptions) : base(dbDonctextOptions)
        {
            
        }

        DbSet<Product> Products { get; set; }

        DbSet<Category> Categories { get; set; }

        DbSet<Picture> Pictures { get; set; }

        DbSet<Cart> Carts { get; set; }

        DbSet<Order> Orders { get; set; }

        DbSet<User> Users { get; set; }

        DbSet<UserProduct> UserProducts { get; set; }

        DbSet<Address> Addresses { get; set; }

        DbSet<City> Cities { get; set; }

        DbSet<Wishlist> Wishlists { get; set; }
    }
}