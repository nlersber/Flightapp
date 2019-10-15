using FlightApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Data.Mappers
{
    public class FlightConfig : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasKey(f=>f.FlightId);
            builder.Property(f => f.FlightId).ValueGeneratedOnAdd();
            builder.Property(f=>f.Duration).IsRequired();
            builder.Property(f => f.Destination).IsRequired();
            builder.Property(f => f.Date).IsRequired();
            builder.Property(f => f.Origin).IsRequired();

            //flight kent haar personeel
            builder.HasMany(f => f.Personnel).WithOne().OnDelete(DeleteBehavior.Restrict);
            //flight kent haar passengergroups
            builder.HasMany(f => f.PassengerGroups).WithOne().OnDelete(DeleteBehavior.Cascade);
            //flight kent haar passengers
            builder.HasMany(f => f.Passengers).WithOne().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
