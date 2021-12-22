using System.Collections.Generic;

namespace GameApi.Domain.Models
{
    public class Player : Entidade
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Level { get; set; }
        public virtual List<PlayerEquipamentos> PlayerEquipamentos { get; set; }
    }
}