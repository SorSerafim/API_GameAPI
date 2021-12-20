using GameApi.Shared.Dtos.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApi.Shared.Dtos.Read
{
    public class PlayersDoEquipamento
    {
        public virtual ReadPlayerDto Player { get; set; }
    }
}
