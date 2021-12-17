using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GameApi.Domain.Models
{
    public class Player : Entidade
    {
        public string Nome { get; set; }
        
        public int Vida { get; set; }
        
        public int Level { get; set; }

        public List<Equipamento> Equipamentos { get; set; }
    }
}