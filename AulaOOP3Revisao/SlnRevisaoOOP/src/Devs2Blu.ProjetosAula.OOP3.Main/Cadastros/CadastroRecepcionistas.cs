using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroRecepcionistas : IMenuCadastro
    {
        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine(" _____________________________________");
            Console.WriteLine("|      Cadastro de Recepcionistas     |");
            Console.WriteLine("|-------------------------------------|");
            Console.WriteLine("|    1 -  Lista de Recepcionistas     |");
            Console.WriteLine("|    2 - Cadastro de Recepcionista    |");
            Console.WriteLine("|    3 -  Alterar Recepcionista       |");
            Console.WriteLine("|    4 -   Exluir Recepcionista       |");
            Console.WriteLine("|-------------------------------------|");
            Console.WriteLine("|      0 -        VOLTAR              |");
            Console.WriteLine("|_____________________________________|");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }
        public void Listar()
        {
            ListarRecepcionistas();
        }

        public void Cadastrar()
        {
            Recepcionista recepcionista;
            Console.Clear();

            string nome, cpf, setor;

            Console.Write($"Informe o Nome do Recepcionista: ");
            nome = Console.ReadLine();
            Console.Write($"Informe o CPF do Recepcionista: ");
            cpf = Console.ReadLine();
            Console.Write($"Informe o Setor do Recepcionista: ");
            setor = Console.ReadLine();

            Random rd = new Random();
            recepcionista = new Recepcionista(rd.Next(11, 100), nome, cpf, setor);
            CadastrarRecepcionista(recepcionista);
        }

        public void Alterar()
        {
            Console.Clear();
            Recepcionista recepcionista;
            int codigoRecepcionista;

            ListarRecepcionistasByCodeAndName();
            Console.WriteLine("Informe o codigo do Recepcionista que deseja alterar: ");
            Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);

            recepcionista = Program.Mock.ListaRecepcionistas.Find(r => r.CodigoRecepcionista == codigoRecepcionista);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.Clear();
                Console.WriteLine($"Recepcionista: {recepcionista.CodigoRecepcionista} | Nome: {recepcionista.Nome} | CPF: {recepcionista.CGCCPF} | Setor: {recepcionista.Setor}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - NOME | 02 - CPF | 03 - SETOR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        recepcionista.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        recepcionista.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo setor:");
                        recepcionista.Setor = Console.ReadLine();
                        break;
                    default:
                        alterar = false;
                        break;
                }
                if (alterar)
                {
                    Console.Clear();
                    Console.WriteLine("Dados alterado com sucesso!");
                    Console.WriteLine("Digite S para continuar alterando:");
                    alterar = (Console.ReadLine().ToUpper().Equals("S")) ? true : false;
                }
            } while (alterar);
            AlterarRecepcionista(recepcionista);
        }

        public void Exlcuir()
        {
            Console.Clear();
            Recepcionista recepcionista;
            int codigoRecepcionista;
            bool excluir = true;

            do
            {
                ListarRecepcionistasByCodeAndName();
                Console.WriteLine("Informe o codigo do Recepcionista que deseja excluir: ");
                Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);

                recepcionista = Program.Mock.ListaRecepcionistas.Find(m => m.CodigoRecepcionista == codigoRecepcionista);
                //------------------
                Console.Clear();
                Console.WriteLine($"Recepcionista: {recepcionista.CodigoRecepcionista} | Nome: {recepcionista.Nome} | CPF: {recepcionista.CGCCPF} | Setor: {recepcionista.Setor}");
                Console.WriteLine($"Deseja excluir o {recepcionista.Nome}? S/N");
                excluir = (Console.ReadLine().ToUpper().Equals("S")) ? true : false;

                if (excluir)
                {
                    Console.Clear();
                    ExcluirRecepcionista(recepcionista);
                    Console.WriteLine("Recepcionista excluido com sucesso!");
                    Console.WriteLine("Digite S para continuar a excluir...");
                    excluir = (Console.ReadLine().ToUpper().Equals("S")) ? true : false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Recepcionista nao foi excluido!");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }
            } while (excluir);
        }
        #region FACADE
        private void ListarRecepcionistasByCodeAndName()
        {
            Console.Clear();
            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"Recepcionista: {recepcionista.CodigoRecepcionista} Nome: {recepcionista.Nome}");
                Console.WriteLine("-------------------------------------------\n");
            }
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
        public void CadastrarRecepcionista(Recepcionista recepcionista)
        {
            Program.Mock.ListaRecepcionistas.Add(recepcionista);
        }
        public void AlterarRecepcionista(Recepcionista recepcionista)
        {
            var recep = Program.Mock.ListaRecepcionistas.Find(r => r.CodigoRecepcionista == recepcionista.CodigoRecepcionista);
            int index = Program.Mock.ListaRecepcionistas.IndexOf(recep);
            Program.Mock.ListaRecepcionistas[index] = recepcionista;
        }
        public void ExcluirRecepcionista(Recepcionista recepcionista)
        {
            Program.Mock.ListaRecepcionistas.Remove(recepcionista);
        }
        #endregion
    }
}
