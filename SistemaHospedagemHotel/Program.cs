using SistemaHospedagemHotel.Models;

Console.WriteLine(" --- Sistema de Hospedagem ---");

Reserva reserva = new Reserva();
Pessoa pessoa = new Pessoa();

string nomeCompleto = null;

Console.WriteLine("\n   1. Cadastro de hóspedes");

do
{
    Console.Write("     --> Informe o nome (simplesmente pressione <ENTER> para sair...): ");

    nomeCompleto = Console.ReadLine();

    if(nomeCompleto.Length > 0 && nomeCompleto != " ")
    {
        string[] nome = { };
        string nomeInicial = "";
        string sobrenome = "";

        nome = nomeCompleto.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        nomeInicial = nome[0];
        
        foreach(string s in nome)
        {
            sobrenome += s + " ";
        }

        sobrenome = sobrenome.Remove(0, nome[0].Length + 1); // Remove o 'nomeInicial' e mais um espaço em branco

        pessoa.Sobrenome = sobrenome;

        // 1. Cadastrar o nome informado como hospede
        reserva.CadastrarHospedes(new Pessoa (nomeInicial, sobrenome));
    }
}while(nomeCompleto != "");

// 2. Selecionar a quantidade de dias hospedado
int diasHospedagem = 0;

do
{
    Console.Write("\n   2. Informe a quantidade de dia(s) desejado: ");
    diasHospedagem = Convert.ToInt32(Console.ReadLine());

    if(diasHospedagem <= 0)
    {
        Console.Clear();
        Console.WriteLine($"\n   --> A quantidade de dia(s) '{diasHospedagem}' é inválida. Tente novamente.");
    }

} while (diasHospedagem <= 0);

// 3. Exibir a quantidade de hospedes
Console.Clear();
Console.WriteLine("\n --- RESUMO DA RESERVA ---");
Console.WriteLine($"\n  --> Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}\n");
reserva.ListarHospedes();

// 4. Recomendação da suíte
reserva.CadastrarSuite();

Console.WriteLine($"\n  --> Dia(s) de hospedagem: {diasHospedagem}");
Console.WriteLine($"\n  --> TOTAL: R${reserva.CalcularValorDiaria(diasHospedagem):N2}");







