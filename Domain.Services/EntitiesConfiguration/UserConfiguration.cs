﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.Model.Entities;
namespace Domain.Services.EntitiesConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("USERS");
            builder.HasKey(x => x.Usrnam);
            //builder.Property(x => x.status).HasConversion(v => v.ToString(),
              //                              v => (Statuses)Enum.Parse(typeof(Statuses), v));
            //builder.Property(x=>x.JobDescription).
        }
    }
}
