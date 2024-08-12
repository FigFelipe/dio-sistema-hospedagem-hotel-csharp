using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel.Models
{
    internal class Pessoa
    {
        // Atributos
        public string Nome { get; set; }
       
        public string Sobrenome { get; set; }


        // Construtores
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // ToString
        public override string ToString()
        {
            return $"{Nome} {Sobrenome}";

        }
    }
}
