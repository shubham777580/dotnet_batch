

//for communication between databbase and c# (model)

using laptopEcommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace laptopEcommerce.Data
{
    public class AppDbContext : DbContext
    //inherit from dbcontext to appdbcontext
    //using Microsoft.EntityFrameworkCore for inheritence
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<>()
            //for not manualing defining identifiers (authentication)
            base.OnModelCreating(modelBuilder);
            
        }

        public DbSet<Laptop_specs> laptop_Specs { get; set; }

        public DbSet<Laptop_specs> laptop_Specs1 { get; set; }

    }
}
