using System.ComponentModel.DataAnnotations;

namespace GameApi.Shared.Dtos.Create
{
    public class CreatePlayerDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Vida é obrigatório")]
        [Range(100, 200, ErrorMessage = "O Dano deve ser no mínimo 0 e no máximo 50.")]
        public int Vida { get; set; }

        [Required(ErrorMessage = "O campo Level é obrigatório")]
        [Range(1, 100, ErrorMessage = "O Level deve ser no mínimo 1 e no máximo 100.")]
        public int Level { get; set; }
    }
}