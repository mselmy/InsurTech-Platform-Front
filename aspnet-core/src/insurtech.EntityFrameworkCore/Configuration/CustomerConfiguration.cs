﻿using insurtech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Configuration
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasMany(u => u.Feedbacks)
                  .WithOne(f => f.Customer)
                  .HasForeignKey(f => f.CustomerId);

            builder.Property(a=>a.NationalId).HasAnnotation("RegularExpression", @"^\d{14}$");
        }
    }
}
