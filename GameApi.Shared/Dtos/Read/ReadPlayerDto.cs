using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApi.Shared.Dtos.Read
{
    public class ReadPlayerDto
    {
        public string Nome { get; set; }

        public int Vida { get; set; }

        public int Level { get; set; }

        //public List<Equipamento> Equipamentos { get; set; }
    }
}
