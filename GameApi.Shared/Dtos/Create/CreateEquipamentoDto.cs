﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApi.Shared.Dtos.Create
{
    public class CreateEquipamentoDto
    {
        public string Nome { get; set; }
        public int Dano { get; set; }
        public int Level { get; set; }
    }
}
