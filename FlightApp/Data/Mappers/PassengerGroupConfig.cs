using FlightApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Data.Mappers
{
    public class PassengerGroupConfig : IEntityTypeConfiguration<PassengerGroup>
    {
        public void Configure(EntityTypeBuilder<PassengerGroup> builder)
        {
            builder.HasKey(pg => pg.PassenGroupId);
            builder.Property(pg => pg.PassenGroupId).ValueGeneratedOnAdd();
        }
    }
}
