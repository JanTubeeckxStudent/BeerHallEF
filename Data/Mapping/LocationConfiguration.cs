﻿using System;
using BeerHallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeerHallEF.Data.Mapping
{
    class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            #region Table
            builder.ToTable("Location");
            #endregion

            #region Key
            builder.HasKey(t => t.PostalCode);
            #endregion

            #region Properties
            builder.Property(t => t.PostalCode)
                        .HasMaxLength(5);

            builder.Property(t => t.Name)
                .HasMaxLength(100);
            #endregion
        }
    }
}
