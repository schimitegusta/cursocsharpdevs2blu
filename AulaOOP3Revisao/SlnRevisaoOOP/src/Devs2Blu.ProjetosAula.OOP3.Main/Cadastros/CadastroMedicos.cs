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
    public class CadastroMedicos : IMenuCadastro
    {
        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine(" _____________________________________");
            Console.WriteLine("|          Cadastro de Medicos        |");
            Console.WriteLine("|-------------------------------------|");
            Console.WriteLine("|      1 -   Lista de Medicos         |");
            Console.WriteLine("|      2 - Cadastro de Medicos        |");
            Console.WriteLine("|      3 -    Alterar Medicos         |");
            Console.WriteLine("|      4 -    Exluir Medicos          |");
            Console.WriteLine("|-------------------------------------|");
            Console.WriteLine("|      0 -        VOLTAR              |");
            Console.WriteLine("|_____________________________________|");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }
        public void Listar()
        {
            ListarMedicos();
        }
        public void Cadastrar()
        {
            Medico medico;
            Console.Clear();

            string nome, cpf, especialidade, crm;

            Console.Write($"Informe o Nome do Medico: ");
            nome = Console.ReadLine();
            Console.Write($"Informe o CPF do Medico: ");
            cpf = Console.ReadLine();
            Console.Write($"Informe o CRM do Medico: ");
            crm = Console.ReadLine();
            Console.Write($"Informe a Especialidade do Medico: ");
            especialidade = Console.ReadLine();

            Random rd = new Random();
            medico = new Medico(rd.Next(11, 100), nome, cpf, crm, especialidade);
            CadastrarMedico(medico);
        }
        public void Alterar()
        {
            Console.Clear();
            Medico medico;
            int codigoMedico;

            ListarMedicosByCodeAndName();
            Console.WriteLine("Informe o codigo do Medico que deseja alterar: ");
            Int32.TryParse(Console.ReadLine(), out codigoMedico);

            medico = Program.Mock.ListaMedicos.Find(p => p.CodigoMedico == codigoMedico);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.Clear();
                Console.WriteLine($"Medico: {medico.CodigoMedico} | Nome: {medico.Nome} | CPF: {medico.CGCCPF} | Especialidade: {medico.Especialidade}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - NOME | 02 - CPF | 03 - CRM | 04 - ESPECIALIDADE");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        medico.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        medico.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo CRM:");
                        medico.CRM = Console.ReadLine();
                        break;
                    case "04":
                        Console.WriteLine("Informe uma nova especialidade:");
                        medico.Especialidade = Console.ReadLine();
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
            AlterarMedico(medico);
        }
        public void Exlcuir()
        {
            Console.Clear();
            Medico medico;
            int codigoMedico;
            bool excluir = true;

            do
            {
                ListarMedicosByCodeAndName();
                Console.WriteLine("Informe o codigo do Medico que deseja excluir: ");
                Int32.TryParse(Console.ReadLine(), out codigoMedico);

                medico = Program.Mock.ListaMedicos.Find(m => m.CodigoMedico == codigoMedico);
                //------------------
                Console.Clear();
                Console.WriteLine($"Medico: {medico.CodigoMedico} | Nome: {medico.Nome} | CPF: {medico.CGCCPF} | Especialidade: {medico.Especialidade}");
                Console.WriteLine($"Deseja excluir o {medico.Nome}? S/N");
                excluir = (Console.ReadLine().ToUpper().Equals("S")) ? true : false;

                if (excluir)
                {
                    Console.Clear();
                    ExcluirMedico(medico);
                    Console.WriteLine("Medico excluido com sucesso!");
                    Console.WriteLine("Digite S para continuar a excluir...");
                    excluir = (Console.ReadLine().ToUpper().Equals("S")) ? true : false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Medico nao foi excluido!");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }
            } while (excluir);
        }
        #region FACADE
        private void ListarMedicosByCodeAndName()
        {
            Console.Clear();
            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"Medico: {medico.CodigoMedico} Nome: {medico.Nome}");
                Console.WriteLine("-------------------------------------------\n");
            }
        }
        private void ListarMedicos()
        {
            Console.Clear();
            foreach (Medico medico in Program.Mock.ListaMedicos)
            {
                //(Int32 codigo, String nome, String cpf, Int32 crm, String especialidade)
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Medico: {medico.CodigoMedico}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"CPF: {medico.CGCCPF}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine($"Especialidade: {medico.Especialidade}");
                Console.WriteLine("-----------------------------\n");
            }
            Console.ReadKey();
        }
        private void CadastrarMedico(Medico medico)
        {
            Program.Mock.ListaMedicos.Add(medico);
        }
        private void AlterarMedico(Medico medico)
        {
            var med = Program.Mock.ListaMedicos.Find(m => m.CodigoMedico == medico.CodigoMedico);
            int index = Program.Mock.ListaMedicos.IndexOf(med);
            Program.Mock.ListaMedicos[index] = medico;
        }
        private void ExcluirMedico(Medico medico)
        {
            Program.Mock.ListaMedicos.Remove(medico);
        }
        #endregion
    }
}
