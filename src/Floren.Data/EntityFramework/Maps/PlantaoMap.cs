using Floren.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Floren.Data.EntityFramework.Maps
{
    public class PlantaoMap : IEntityTypeConfiguration<Plantao>
    {
        public void Configure(EntityTypeBuilder<Plantao> builder)
        {
            //Tabelas
            builder.ToTable(nameof(Plantao));

            //PK
            builder.HasKey(pk => pk.Id);

            //Colunas
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.Property(x => x.FarmaciaPrincipal)
                .IsRequired();


            builder.Property(x => x.FarmaciaSecundaria)
                .IsRequired();

        }
    }
}