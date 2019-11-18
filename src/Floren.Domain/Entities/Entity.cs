using System;

namespace Floren.Domain.Entities
{
    public abstract class Entity
    {
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }


}