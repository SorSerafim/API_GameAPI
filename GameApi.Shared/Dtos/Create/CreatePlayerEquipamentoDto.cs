using System.ComponentModel.DataAnnotations;

namespace GameApi.Shared.Dtos.Create
{
    public class CreatePlayerEquipamentoDto
    {
        [Required(ErrorMessage = "O campo PlayerId é obrigatório")]
        public int PlayerId { get; set; }
        [Required(ErrorMessage = "O campo EquipamentoId é obrigatório")]
        public int EquipamentoId { get; set; }
    }
}
