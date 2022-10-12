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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Macbook",
                Price = 9999,
                Description = "Laptop da Apple",
                CategoryName = "Tecnologia",
                ImageUrl = "abc123"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Bicicleta",
                Price = 10000,
                Description = "Bicicleta para pedalar",
                CategoryName = "Saúde",
                ImageUrl = "abc123"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Desengordurante",
                Price = 8.99M,
                Description = "Para tirar a gordura da cozinha",
                CategoryName = "Limpeza",
                ImageUrl = "abc123"
            });
        }
    }
}

