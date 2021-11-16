using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIYPizza.Models
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Malzeme>().HasData(
                new Malzeme() { Id = 1, Ad = "Mozzarella Peyniri" },
                new Malzeme() { Id = 2, Ad = "Pizza Sosu" },
                new Malzeme() { Id = 3, Ad = "Mısır" },
                new Malzeme() { Id = 4, Ad = "Zeytin" },
                new Malzeme() { Id = 5, Ad = "Salam" },
                new Malzeme() { Id = 6, Ad = "Sucuk" },
                new Malzeme() { Id = 7, Ad = "Sosis" },
                new Malzeme() { Id = 8, Ad = "Biber" },
                new Malzeme() { Id = 9, Ad = "Mantar" },
                new Malzeme() { Id = 10, Ad = "Pastırma" },
                new Malzeme() { Id = 11, Ad = "Ananas" },
                new Malzeme() { Id = 12, Ad = "Ton Balığı" },
                new Malzeme() { Id = 13, Ad = "Rokfor Peyniri" },
                new Malzeme() { Id = 14, Ad = "Kaşar Peyniri" },
                new Malzeme() { Id = 15, Ad = "Kavurma" },
                new Malzeme() { Id = 16, Ad = "Füme" },
                new Malzeme() { Id = 17, Ad = "Soğan" },
                new Malzeme() { Id = 18, Ad = "Tavuk" },
                new Malzeme() { Id = 19, Ad = "Parmesan Peyniri" },
                new Malzeme() { Id = 20, Ad = "Domates" }
                );
        }

        public DbSet<Malzeme> Malzemeler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
    }
}
