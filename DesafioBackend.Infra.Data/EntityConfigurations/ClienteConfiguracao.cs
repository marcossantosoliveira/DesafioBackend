using DesafioBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioBackend.Infra.Data.EntityConfigurations
{
    public class ClienteConfiguracao : IEntityTypeConfiguration<Clientes>
    {
        public void Configure(EntityTypeBuilder<Clientes> builder)
        {
            builder.Property(p => p.Nome)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(p => p.Id)
                   .HasDefaultValue(new Guid());

            builder.Property(p => p.Email)
                   .IsRequired();

            builder.Property(p => p.MultiplicadorBase)
                   .IsRequired();

        }
    }
}
