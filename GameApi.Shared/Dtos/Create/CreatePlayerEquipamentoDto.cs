using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApi.Shared.Dtos.Create
{
    public class CreatePlayerEquipamentoDto
    {
        public int PlayerId { get; set; }

        public int EquipamentoId { get; set; }
    }
}
