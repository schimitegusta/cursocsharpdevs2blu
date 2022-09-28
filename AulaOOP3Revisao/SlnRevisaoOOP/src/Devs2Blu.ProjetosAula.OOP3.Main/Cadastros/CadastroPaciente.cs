using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroPaciente : IMenuCadastro
    {
        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine(" _____________________________________");
            Console.WriteLine("|        Cadastro de Pacientes        |");
            Console.WriteLine("|-------------------------------------|");
            Console.WriteLine("|      1 -   Lista de Pacientes       |");
            Console.WriteLine("|      2 - Cadastro de Pacientes      |");
            Console.WriteLine("|      3 -   Alterar Pacientes        |");
            Console.WriteLine("|      4 -    Exluir Pacientes        |");
            Console.WriteLine("|-------------------------------------|");
            Console.WriteLine("|      0 -        VOLTAR              |");
            Console.WriteLine("|_____________________________________|");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }
        public void Listar()
        {
            ListarPacientes();
        }
        public void Cadastrar()
        {
            Paciente paciente = new Paciente();
            CadastrarPaciente(paciente);
        }
        public void Alterar()
        {
            Console.Clear();
            Paciente paciente;
            int codigoPaciente;

            ListarPacientesByCodeAndName();
            Console.WriteLine("Informe o codigo do Paciente que deseja alterar: ");
            Int32.TryParse(Console.ReadLine(), out codigoPaciente);

            paciente = Program.Mock.ListaPacientes.Find(p => p.CodigoPaciente == codigoPaciente);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.Clear();
                Console.WriteLine($"Paciente: {paciente.CodigoPaciente} | Nome: {paciente.Nome} | CPF: {paciente.CGCCPF} | Convenio: {paciente.Convenio}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - NOME | 02 - CPF | 03 - CONVENIO");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        paciente.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo cpf:");
                        paciente.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo convenio:");
                        paciente.Convenio = Console.ReadLine();
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

            AlterarPaciente(paciente);
        }
        public void Exlcuir()
        {
            Console.Clear();
            Paciente paciente;
            int codigoPaciente;
            bool excluir = true;

            do
            {
                ListarPacientesByCodeAndName();
                Console.WriteLine("Informe o codigo do Paciente que deseja excluir: ");
                Int32.TryParse(Console.ReadLine(), out codigoPaciente);

                paciente = Program.Mock.ListaPacientes.Find(p => p.CodigoPaciente == codigoPaciente);
                //------------------
                Console.Clear();
                Console.WriteLine($"Paciente: {paciente.CodigoPaciente} | Nome: {paciente.Nome} | CPF: {paciente.CGCCPF} | Convenio: {paciente.Convenio}");
                Console.WriteLine($"Deseja excluir o {paciente.Nome}? S/N");
                excluir = (Console.ReadLine().ToUpper().Equals("S")) ? true : false;
                ExcluirPaciente(paciente);

                if (excluir)
                {
                    Console.Clear();
                    Console.WriteLine("Paciente excluido com sucesso!");
                    Console.WriteLine("Digite S para continuar a excluir...");
                    excluir = (Console.ReadLine().ToUpper().Equals("S")) ? true : false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Paciente nao foi excluido!");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }
            } while (excluir);
        }

        #region FACADE
        private void ListarPacientesByCodeAndName()
        {
            Console.Clear();
            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"Paciente: {paciente.CodigoPaciente} Nome: {paciente.Nome}");
                Console.WriteLine("-------------------------------------------\n");
            }
        }
        private void ListarPacientes()
        {
            Console.Clear();
            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Paciente: {paciente.CodigoPaciente}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"CPF: {paciente.CGCCPF}");
                Console.WriteLine($"Convenio: {paciente.Convenio}");
                Console.WriteLine("-----------------------------\n");
            }
            Console.ReadKey();
        }
        private void CadastrarPaciente(Paciente paciente)
        {
            Console.Clear();

            string nome, cpf, convenio;

            Console.Write($"Informe o Nome do Paciente: ");
            nome = Console.ReadLine();
            Console.Write($"Informe o CPF do Paciente: ");
            cpf = Console.ReadLine();
            Console.Write($"Informe o Convenio do Paciente: ");
            convenio = Console.ReadLine();

            Random rd = new Random();
            paciente = new Paciente(rd.Next(11, 100), nome, cpf, convenio);
            Program.Mock.ListaPacientes.Add(paciente);
        }
        private void AlterarPaciente(Paciente paciente)
        {
            var pact = Program.Mock.ListaPacientes.Find(p => p.CodigoPaciente == paciente.CodigoPaciente);
            int index = Program.Mock.ListaPacientes.IndexOf(pact);
            Program.Mock.ListaPacientes[index] = paciente;
        }
        private void ExcluirPaciente(Paciente paciente)
        {
            Program.Mock.ListaPacientes.Remove(paciente);
        }
        #endregion
    }
}
