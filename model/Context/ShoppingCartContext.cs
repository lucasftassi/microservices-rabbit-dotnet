using System;
using Microsoft.EntityFrameworkCore;

namespace microservices_rabbit.model.Context
{
    public class ShoppingCartContext : DbContext
    {
        public ShoppingCartContext()
        {
        }

        public ShoppingCartContext(DbContextOptions<ShoppingCartContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}

