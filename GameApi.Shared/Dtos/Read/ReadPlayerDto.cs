using System.Collections.Generic;

namespace GameApi.Shared.Dtos.Read
{
    public class ReadPlayerDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Level { get; set; }
        public virtual List<ReadEquipamentoDto> Equipamentos { get; set; } 
    }
}
