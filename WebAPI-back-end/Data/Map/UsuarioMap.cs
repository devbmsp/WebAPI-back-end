﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI_back_end.Models;

namespace WebAPI_back_end.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>

    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)

        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(150);

        }
    }
}
