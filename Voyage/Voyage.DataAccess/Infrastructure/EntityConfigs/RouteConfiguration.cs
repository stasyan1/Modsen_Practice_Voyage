﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Voyage.DataAccess.Entities;

namespace Voyage.DataAccess.Infrastructure.EntityConfigs
{
    internal class RouteConfiguration : IEntityTypeConfiguration<Route>
    {
        public void Configure(EntityTypeBuilder<Route> builder)
        {
            builder.Property(r => r.Name).HasMaxLength(100);
            builder.Property(r => r.DepartureAddress).HasMaxLength(200);
            builder.Property(r => r.DestinationAddress).HasMaxLength(200);
        }
    }
}