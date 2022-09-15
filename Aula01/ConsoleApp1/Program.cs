using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string formatacaoDados = "Inicialização de variável...\n";
            string nomeUsuario, cidadeUsuario;
            //nomeUsuario = "Gustavo Schimite Soares";

            Console.Write("Informe seu nome: ");
            nomeUsuario = Console.ReadLine();

            Console.Write("Informe sua cidade: ");
            cidadeUsuario = Console.ReadLine();

            // O "+" vai concatenar o Dado da variável com os novos dados após o sinal de "="
            // Existe outra forma de concatenar também, usando $"texto {variável}"
            formatacaoDados += "Seja bem vindo(a), " + nomeUsuario + "!\n\n";
            formatacaoDados += $"Localidade: {cidadeUsuario}";

            Console.WriteLine();
            Console.WriteLine(formatacaoDados);

            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para sair...");
            var input = Console.ReadLine();
        }
    }
}
