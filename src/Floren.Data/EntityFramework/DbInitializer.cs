using Floren.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Floren.Data.EntityFramework
{
    public static class DbInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Farmacia>()
                .HasData(
                    new Farmacia() { Id = 1, Nome = "Farmácia Drogacenter", Telefone = "(44) 3425-1367", Endereco = "Av. Brasil, 1227" },
                    new Farmacia() { Id = 2, Nome = "Farmácia São Lucas", Telefone = "(44) 3425-1011", Endereco = "Rua Tókio, 343 - Centro" },
                    new Farmacia() { Id = 3, Nome = "Farmácia Farma & Farma", Telefone = "(44) 3425 - 3700", Endereco = "Av.Pres.Get.Vargas, 1041 - Centro" },
                    new Farmacia() { Id = 4, Nome = "Farmácia União", Telefone = "(44) 3425-2555", Endereco = "Av.Des.M.de Mello, 1437 - Centro" },
                    new Farmacia() { Id = 5, Nome = "Farmácia Farma Útil", Telefone = "(44) 3425-2539", Endereco = "Av.Brasil, 1137 - Centro" },
                    new Farmacia() { Id = 6, Nome = "Farmácia Rede Líder", Telefone = "(44) 3425-5200", Endereco = "Av.Paraná, 1165 - Centro" },
                    new Farmacia() { Id = 7, Nome = "Farmácia Du Preço Popular", Telefone = "(44) 3425 - 2921", Endereco = "Rua Accioly Filho, 448 - Centro" },
                    new Farmacia() { Id = 8, Nome = "Farmácia Preço Baixo", Telefone = "(44) 3425 - 1388", Endereco = "Avenida Paraná, 1198 Centro" },
                    new Farmacia() { Id = 9, Nome = "Farmácia Sto.Antônio", Telefone = "(44) 3425-5725", Endereco = "Av.Brasil, 819 - Centro" },
                    new Farmacia() { Id = 10, Nome = "Farmácia Sta.Terezinha", Telefone = "(44) 3425-1323", Endereco = "Av.Brasil, 1094 - Centro" },
                    new Farmacia() { Id = 11, Nome = "Farmácia Drogaminas", Telefone = "(44) 3425 - 1090", Endereco = "Av.Paraná, 1147 - Vila Nova" },
                    new Farmacia() { Id = 12, Nome = "Farmácia Droganova", Telefone = "(44) 3425 - 1304", Endereco = "Av.Paraná, 1952 - Vila Nova" },
                    new Farmacia() { Id = 13, Nome = "Farmácia Do Paulo", Telefone = "(44) 3425 - 1915", Endereco = "Rua Accioly Filho, 584 - Centro" }
                );

            modelBuilder.Entity<Plantao>()
                .HasData(
                new Plantao() { Id = 1, Nome = "G1", FarmaciaPrincipal = 9, FarmaciaSecundaria = 10 },
                new Plantao() { Id = 2, Nome = "G2", FarmaciaPrincipal = 1, FarmaciaSecundaria = 11 },
                new Plantao() { Id = 3, Nome = "G3", FarmaciaPrincipal = 2, FarmaciaSecundaria = 12 },
                new Plantao() { Id = 4, Nome = "G4", FarmaciaPrincipal = 13, FarmaciaSecundaria = 3 },
                new Plantao() { Id = 5, Nome = "G5", FarmaciaPrincipal = 4, FarmaciaSecundaria = 6 },
                new Plantao() { Id = 6, Nome = "G6", FarmaciaPrincipal = 5, FarmaciaSecundaria = 8 },
                new Plantao() { Id = 7, Nome = "G7", FarmaciaPrincipal = 7, FarmaciaSecundaria = 9 },
                new Plantao() { Id = 8, Nome = "G8", FarmaciaPrincipal = 10, FarmaciaSecundaria = 11 },
                new Plantao() { Id = 9, Nome = "G9", FarmaciaPrincipal = 1, FarmaciaSecundaria = 2 },
                new Plantao() { Id = 10, Nome = "G10", FarmaciaPrincipal = 12, FarmaciaSecundaria = 13 },
                new Plantao() { Id = 11, Nome = "G11", FarmaciaPrincipal = 3, FarmaciaSecundaria = 4 },
                new Plantao() { Id = 12, Nome = "G12", FarmaciaPrincipal = 6, FarmaciaSecundaria = 5 },
                new Plantao() { Id = 13, Nome = "G13", FarmaciaPrincipal = 8, FarmaciaSecundaria = 7 }
            );

        }
    }
}