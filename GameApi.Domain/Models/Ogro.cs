using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameApi.Domain.Models
{
    public class Ogro
    {
        public int Id { get; private set; }

        public int Vida { get; set; }

        public int Defesa { get; set; }

        public int Dano { get; set; }
    }
}
