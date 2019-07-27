using System;

namespace FisioAvalia.Models.Base
{
    public class Entity
    {
        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
        public Entity() { }
    }
}
