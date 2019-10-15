using FlightApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Data.Mappers
{
    public class PassengerConfig : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.HasKey(p=>p.PassengerId);
            builder.Property(p=>p.PassengerId).ValueGeneratedOnAdd();
            builder.Property(p=>p.FirstName).IsRequired();
            builder.Property(p => p.LastName).IsRequired();

            //passenger kent zijn seat, seat kent passenger
            builder.HasOne(p=>p.Seat).WithOne(s=>s.Passenger).OnDelete(DeleteBehavior.Restrict);
            //passenger kent zijn passengergroup, passengergroup kent zijn passengers
            builder.HasOne(p => p.Group).WithMany(g => g.Passengers).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
