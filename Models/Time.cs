using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex05.Models
{
    public class Time
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int anoCriacao { get; set; }
        public string estado { get; set; }
        public string bandeira { get; set; }
        public string mascote { get; set; }
        public int qtdeTitulosBrasileiros { get; set; }
        public int qtdeCopaBrasil { get; set; }
        public int qtdeTitulosRegionais { get; set; }
    }
}
