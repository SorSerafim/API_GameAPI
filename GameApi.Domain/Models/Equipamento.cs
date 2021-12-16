using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GameApi.Domain.Models
{
    public class Equipamento : Entidade
    {
        public string Nome { get; set; }

        public int Dano { get; set; }

        public int Level { get; set; }

        public Player Player { get; set; }

        public int PlayerId { get; set; }
    }
}