using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroRecepcionistas
    {
        public void MenuCadastro()
        {
            Int32 opcao;
            do
            {
                Console.Clear();
                Console.WriteLine(" _____________________________________");
                Console.WriteLine("|      Cadastro de Recepcionistas     |");
                Console.WriteLine("|-------------------------------------|");
                Console.WriteLine("|    1 -  Lista de Recepcionistas     |");
                Console.WriteLine("|    2 - Cadastro de Recepcionista    |");
                Console.WriteLine("|    3 -   Alterar Recepcionista      |");
                Console.WriteLine("|-------------------------------------|");
                Console.WriteLine("|      0 -        VOLTAR              |");
                Console.WriteLine("|_____________________________________|");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarRecepcionistas();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastrarRecepcionista();
                        break;
                    default:
                        break;
                }
            } while (!opcao.Equals((int)MenuEnums.SAIR));
        }
        public void ListarRecepcionistas()
        {
            Console.Clear();
            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                //(Int32 codigo, String nome, String cpf, String setor)
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Recepcionista: {recepcionista.CodigoRecepcionista}");
                Console.WriteLine($"Nome: {recepcionista.Nome}");
                Console.WriteLine($"CPF: {recepcionista.CGCCPF}");
                Console.WriteLine($"Setor: {recepcionista.Setor}");
                Console.WriteLine("-----------------------------\n");
            }
            Console.ReadKey();
        }
        public void CadastrarRecepcionista()
        {
            Console.Clear();

            string nome, cpf, setor;

            Console.Write($"Informe o Nome do Recepcionista: ");
            nome = Console.ReadLine();
            Console.Write($"Informe o CPF do Recepcionista: ");
            cpf = Console.ReadLine();
            Console.Write($"Informe o Setor do Recepcionista: ");
            setor = Console.ReadLine();

            Random rd = new Random();
            Recepcionista recepcionista = new Recepcionista(rd.Next(11, 100), nome, cpf, setor);
            Program.Mock.ListaRecepcionistas.Add(recepcionista);
        }
        public void AlterarRecepcionista()
        {

        }
        public void ExcluirRecepcionista()
        {

        }
    }
}
