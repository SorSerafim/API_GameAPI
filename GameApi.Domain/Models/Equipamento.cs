using System.Collections.Generic;

namespace GameApi.Domain.Models
{
    public class Equipamento : Entidade
    {
        public string Nome { get; set; }
        public int Dano { get; set; }
        public int Level { get; set; }
        public virtual List<PlayerEquipamentos> PlayerEquipamentos { get; set; }
    }
}