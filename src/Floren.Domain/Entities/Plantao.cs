using System;

namespace Floren.Domain.Entities
{
    public class Plantao : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int FarmaciaPrincipal { get; set; }
        public int FarmaciaSecundaria { get; set; }
        public int Escala { get; set; }
        public bool Status { get; set; }
    }
}