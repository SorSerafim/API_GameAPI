using System.Text.Json.Serialization;

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
