using FlightApp.Data.Mappers;
using FlightApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Entertainment> Entertainment { get; set; }
        public DbSet<Orderline> Orders { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Personnel> Stewards { get; set; }
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new EntertainmentConfig());
            builder.ApplyConfiguration(new OrderlineConfig());
            builder.ApplyConfiguration(new PassengerConfig());
            builder.ApplyConfiguration(new PersonnelConfig());
            builder.ApplyConfiguration(new ProductsConfig());
            builder.ApplyConfiguration(new FlightConfig());
            builder.ApplyConfiguration(new PassengerGroupConfig());
            builder.ApplyConfiguration(new SeatConfig());


        }
    }
}
