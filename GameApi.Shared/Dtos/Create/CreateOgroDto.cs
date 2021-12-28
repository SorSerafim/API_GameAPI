using System.ComponentModel.DataAnnotations;

namespace GameApi.Shared.Dtos.Create
{
    public class CreateOgroDto
    {
        [Required(ErrorMessage = "O campo Vida é obrigatório")]
        [Range(100, 200, ErrorMessage = "O Dano deve ser no mínimo 0 e no máximo 50.")]
        public int Vida { get; set; }

        [Required(ErrorMessage = "O campo Defesa é obrigatório")]
        [Range(1, 100, ErrorMessage = "O Defesa deve ser no mínimo 0 e no máximo 50.")]
        public int Defesa { get; set; }

        [Required(ErrorMessage = "O campo Dano é obrigatório")]
        [Range(0, 50, ErrorMessage = "O Dano deve ser no mínimo 0 e no máximo 50.")]
        public int Dano { get; set; }
    }
}