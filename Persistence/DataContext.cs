using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Customer>()
            .HasData(
                new Customer 
                {
                    Id = 1,
                    First_name = "John",
                    Last_name = "Munroe",
                    DOB = new DateTime(1980,8,24),
                    Gender = "Male"
                },
                new Customer
                {
                    Id = 2,
                    First_name = "Danica",
                    Last_name = "Blake",
                    DOB = new DateTime(1990,7,14),
                    Gender = "Female"
                },
                new Customer
                {
                    Id = 3,
                    First_name = "Monica",
                    Last_name = "Sandy",
                    DOB = new DateTime(1998,2,12),
                    Gender = "Female"
                },
                new Customer
                {
                    Id = 4,
                    First_name = "Colm",
                    Last_name = "Blair",
                    DOB = new DateTime(1970,2,2),
                    Gender = "Male"
                },
                new Customer
                {
                    Id = 5,
                    First_name = "Declan",
                    Last_name = "Rowley",
                    DOB = new DateTime(1984,12,20),
                    Gender = "Male"
                }
            );
        }
    }
}
