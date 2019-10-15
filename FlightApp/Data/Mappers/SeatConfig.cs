using FlightApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Data.Mappers
{
    public class SeatConfig : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.HasKey(s=>s.SeatId);
            builder.Property(s=>s.SeatId).ValueGeneratedOnAdd();
            builder.Property(s=>s.SeatNumber).IsRequired();
        }
    }
}
