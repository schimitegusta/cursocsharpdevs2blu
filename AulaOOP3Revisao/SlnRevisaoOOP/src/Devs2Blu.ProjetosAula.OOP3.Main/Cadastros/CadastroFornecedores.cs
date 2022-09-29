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
    public class CadastroFornecedores : IMenuCadastro
    {
        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine(" _____________________________________");
            Console.WriteLine("|        Cadastro de Fornecedores     |");
            Console.WriteLine("|-------------------------------------|");
            Console.WriteLine("|    1 -     Lista de Fornecedores    |");
            Console.WriteLine("|    2 -    Cadastro de Fornecedor    |");
            Console.WriteLine("|    3 -      Alterar Fornecedor      |");
            Console.WriteLine("|    4 -       Exluir Fornecedor      |");
            Console.WriteLine("|-------------------------------------|");
            Console.WriteLine("|      0 -        VOLTAR              |");
            Console.WriteLine("|_____________________________________|");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }
        public void Listar()
        {
            ListarFornecedores();
        }

        public void Cadastrar()
        {
            Fornecedor fornecedor;
            Console.Clear();

            string nome, cpf, setor, tipoFornecedor;

            Console.Write($"Informe o Nome do Fornecedor: ");
            nome = Console.ReadLine();
            Console.Write($"Informe o CPF do Fornecedor: ");
            cpf = Console.ReadLine();
            Console.Write($"Informe o Setor do Fornecedor: ");
            setor = Console.ReadLine();
            Console.Write($"Informe o tipo do Fornecedor: ");
            tipoFornecedor = Console.ReadLine();

            Random rd = new Random();
            fornecedor = new Fornecedor(rd.Next(1000, 4000), nome, cpf, tipoFornecedor);
            CadastrarFornecedor(fornecedor);
        }

        public void Alterar()
        {
            Console.Clear();
            Fornecedor fornecedor;
            int codigoFornecedor;

            ListarFornecedoresByCodeAndName();
            Console.WriteLine("Informe o codigo do Fornecedor que deseja alterar: ");
            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);

            fornecedor = Program.Mock.ListaFornecedores.Find(r => r.CodigoFornecedor == codigoFornecedor);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.Clear();
                Console.WriteLine($"Fornecedor: {fornecedor.CodigoFornecedor} | Nome: {fornecedor.Nome} | CPF: {fornecedor.CGCCPF} | Tipo Fornecedor: {fornecedor.TipoFornecedor}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - NOME | 02 - CPF | 03 - TIPO FORNECEDOR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        fornecedor.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        fornecedor.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo tipo de fornecedor:");
                        fornecedor.TipoFornecedor = Console.ReadLine();
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
            AlterarFornecedor(fornecedor);
        }

        public void Exlcuir()
        {
            Console.Clear();
            Fornecedor fornecedor;
            int codigoFornecedor;
            bool excluir = true;

            do
            {
                ListarFornecedoresByCodeAndName();
                Console.WriteLine("Informe o codigo do Fornecedor que deseja excluir: ");
                Int32.TryParse(Console.ReadLine(), out codigoFornecedor);

                fornecedor = Program.Mock.ListaFornecedores.Find(m => m.CodigoFornecedor == codigoFornecedor);
                //------------------
                Console.Clear();
                Console.WriteLine($"Fornecedor: {fornecedor.CodigoFornecedor} | Nome: {fornecedor.Nome} | CPF: {fornecedor.CGCCPF} | Tipo do Fornecedor: {fornecedor.TipoFornecedor}");
                Console.WriteLine($"Deseja excluir o {fornecedor.Nome}? S/N");
                excluir = (Console.ReadLine().ToUpper().Equals("S")) ? true : false;

                if (excluir)
                {
                    Console.Clear();
                    ExcluirFornecedor(fornecedor);
                    Console.WriteLine("Fornecedor excluido com sucesso!");
                    Console.WriteLine("Digite S para continuar a excluir...");
                    excluir = (Console.ReadLine().ToUpper().Equals("S")) ? true : false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Fornecedor nao foi excluido!");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }
            } while (excluir);
        }
        #region FACADE
        private void ListarFornecedoresByCodeAndName()
        {
            Console.Clear();
            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"Fornecedor: {fornecedor.CodigoFornecedor} Nome: {fornecedor.Nome}");
                Console.WriteLine("-------------------------------------------\n");
            }
        }
        public void ListarFornecedores()
        {
            Console.Clear();
            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                //(Int32 codigo, String nome, String cpf, String tipoFornecedor)
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Fornecedor: {fornecedor.CodigoFornecedor}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"CPF: {fornecedor.CGCCPF}");
                Console.WriteLine($"Tipo Fornecedor: {fornecedor.TipoFornecedor}");
                Console.WriteLine("-----------------------------\n");
            }
            Console.ReadKey();
        }
        public void CadastrarFornecedor(Fornecedor fornecedor)
        {
            Program.Mock.ListaFornecedores.Add(fornecedor);
        }
        public void AlterarFornecedor(Fornecedor fornecedor)
        {
            var fornec = Program.Mock.ListaFornecedores.Find(r => r.CodigoFornecedor == fornecedor.CodigoFornecedor);
            int index = Program.Mock.ListaFornecedores.IndexOf(fornec);
            Program.Mock.ListaFornecedores[index] = fornecedor;
        }
        public void ExcluirFornecedor(Fornecedor fornecedor)
        {
            Program.Mock.ListaFornecedores.Remove(fornecedor);
        }
        #endregion
    }
}
