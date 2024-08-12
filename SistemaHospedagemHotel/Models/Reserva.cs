using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel.Models
{
    internal class Reserva
    {

        public CultureInfo culture = new CultureInfo("en-US");

        // Atributos

        List<Pessoa> listaHospedes = new List<Pessoa>();
        Suite suite = new Suite();
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(Pessoa pessoa)
        {
            listaHospedes.Add(pessoa);
        }

        public void ListarHospedes()
        {
            int aux = 1;

            foreach (Pessoa p in listaHospedes)
            {
                Console.WriteLine($"        {aux}. {culture.TextInfo.ToTitleCase(p.Nome)} {culture.TextInfo.ToTitleCase(p.Sobrenome)}");
                aux++;
            }

        }

        public void CadastrarSuite()
        {
            Console.WriteLine("\n --- Suíte recomendada ---");

            if (ObterQuantidadeHospedes() < 4)
            {
                Console.WriteLine("\n  --> Suíte 'Comum', até 3 hóspedes, R$30,00/dia");

                suite = new Suite("Comum", 3, 30.00m);
            }
            else
            {
                Console.WriteLine("\n  --> Suíte 'Premium', a partir de 4 hóspedes, R$50,00/dia");

                suite = new Suite("Premium", 10, 50.00m);
            }

        }

        public int ObterQuantidadeHospedes()
        {
            return listaHospedes.Count;
        }

        public decimal CalcularValorDiaria(int diasHospedagem)
        {
            decimal precoTotal = 0m;

            precoTotal = diasHospedagem * suite.PrecoDiaria;

            if (ObterQuantidadeHospedes() > 3 && diasHospedagem >= 5)
            {
                Console.WriteLine("\n   >> GANHOU DESCONTO - 10% OFF! <<");
                precoTotal -= precoTotal * 0.1m;
            }

            return precoTotal;
        }
    }   
}
