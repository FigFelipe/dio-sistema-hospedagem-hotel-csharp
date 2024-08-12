using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel.Models
{
    internal class Suite
    {
       

        // Atributos
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal PrecoDiaria { get; set; }

        // Construtores
        public Suite()
        {
        }
        public Suite(string tipoSuite, int capacidade, decimal precoDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            PrecoDiaria = precoDiaria;
        }
    }
}
