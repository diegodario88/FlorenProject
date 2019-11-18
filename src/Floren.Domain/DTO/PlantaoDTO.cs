using Floren.Domain.Entities;

namespace Floren.Domain.DTO
{
    public class PlantaoDTO
    {
        public string Grupo { get; set; }

        public FarmaciaDTO Principal { get; set; }

        public FarmaciaDTO Secundaria { get; set; }

    }
}