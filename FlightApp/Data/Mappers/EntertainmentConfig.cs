using FlightApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Data.Mappers
{
    public class EntertainmentConfig : IEntityTypeConfiguration<Entertainment>
    {
        public void Configure(EntityTypeBuilder<Entertainment> builder)
        {
            builder.HasKey(e => e.EntertainmentId);
            builder.Property(e => e.EntertainmentId).ValueGeneratedOnAdd();
            builder.Property(e => e.EntertainmentType).IsRequired();
            builder.Property(e => e.Description).IsRequired();
            builder.Property(e => e.Duration).IsRequired();
            builder.Property(e => e.Genre).IsRequired();
            builder.Property(e => e.Title).IsRequired();
        }
    }
}
