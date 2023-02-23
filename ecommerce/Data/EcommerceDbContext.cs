using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Data
{
    public class EcommerceDbContext : DbContext
    {
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<ShopingCartItem> ShopingCartItems => Set<ShopingCartItem>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData
            (
                new Product{Id = 1, Name="Americano",Price=25,Detail="The Americano coffe is a classic expresso-based drink",ImageUrl="https://th.bing.com/th/id/OIP.eTEn2xfvC_fL9C2P-ZfKpgHaHa?w=173&h=180&c=7&r=0&o=5&pid=1.7"},

                new Product{Id = 2, Name="Freezer Coffee",Price=25,Detail="The Freeze Coffee ",ImageUrl="https://th.bing.com/th/id/OIP.Ry5aE9jiYBVZGTJrLNCfbQHaL2?w=115&h=180&c=7&r=0&o=5&pid=1.7"},

                new Product{Id = 3, Name="Express Coffe",Price=25,Detail="The Express Coffee",ImageUrl="https://th.bing.com/th/id/OIP.o-eiK1tjgp3ewYlsI78oBwHaHa?w=196&h=196&c=7&r=0&o=5&pid=1.7"}
            );
        }
    }
}