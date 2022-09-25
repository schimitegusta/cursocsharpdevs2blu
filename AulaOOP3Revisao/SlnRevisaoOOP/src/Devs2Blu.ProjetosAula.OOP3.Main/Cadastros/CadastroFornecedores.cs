﻿using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroFornecedores
    {
        public void MenuCadastro()
        {
            Int32 opcao;
            do
            {
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

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarFornecedores();
                        break;
                    default:
                        break;
                }
            } while (!opcao.Equals((int)MenuEnums.SAIR));
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
        public void CadastrarFornecedor()
        {

        }
        public void AlterarFornecedor()
        {

        }
        public void ExcluirFornecedor()
        {

        }
    }
}
