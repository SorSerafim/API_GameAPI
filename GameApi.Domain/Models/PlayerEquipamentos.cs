using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GameApi.Domain.Models
{
    public class PlayerEquipamentos : Entidade
    {
        [JsonIgnore]
        public virtual Player Player { get; set; }
        [JsonIgnore]
        public virtual Equipamento Equipamento { get; set; }
        public int PlayerId { get; set; }
        public int EquipamentoId { get; set; }
    }
}
