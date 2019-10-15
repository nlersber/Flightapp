using FlightApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightApp.Data.Mappers
{
    public class OrderlineConfig : IEntityTypeConfiguration<Orderline>
    {
        public void Configure(EntityTypeBuilder<Orderline> builder)
        {
            builder.HasKey(o => o.OrderLineId);
            builder.Property(o => o.OrderLineId).ValueGeneratedOnAdd();
            builder.Property(o => o.NumberOfProductItems).IsRequired();

            //orderline kent haar product
            builder.HasOne(o => o.Product).WithMany();
            //orderline kent haar passenger die besteld heeft, passenger kent zijn orders
            builder.HasOne(o => o.Passenger).WithMany(p => p.Orders).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
