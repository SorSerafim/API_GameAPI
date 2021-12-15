using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApi.Domain.Models
{
    public class Player
    {

        public int Id { get; private set; }

        public string Nome { get; set; }
        
        public int Vida { get; set; }
        
        public int Level { get; set; }
    }
}