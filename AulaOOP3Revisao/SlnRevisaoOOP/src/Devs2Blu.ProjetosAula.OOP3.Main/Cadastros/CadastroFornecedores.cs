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
            Fornecedor fornecedor = new Fornecedor();
            CadastrarFornecedor(fornecedor);
        }

        public void Alterar()
        {
            Fornecedor fornecedor = new Fornecedor();
            AlterarFornecedor(fornecedor);
        }

        public void Exlcuir()
        {
            Fornecedor fornecedor = new Fornecedor();
            ExcluirFornecedor(fornecedor);
        }
        #region FACADE
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
            Program.Mock.ListaFornecedores.Add(fornecedor);
        }
        public void AlterarFornecedor(Fornecedor fornecedor)
        {

        }
        public void ExcluirFornecedor(Fornecedor fornecedor)
        {

        }
        #endregion
    }
}
