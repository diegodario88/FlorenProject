using Floren.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Floren.Data.EntityFramework.Maps
{
    public class FarmaciaMap : IEntityTypeConfiguration<Farmacia>
    {
        public void Configure(EntityTypeBuilder<Farmacia> builder)
        {
            //Tabelas
            builder.ToTable(nameof(Farmacia));

            //PK
            builder.HasKey(pk => pk.Id);

            //Colunas
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.Property(x => x.Endereco)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.Property(x => x.Telefone)
                .IsRequired()
                .HasColumnType("varchar(50)");

        }
    }
}