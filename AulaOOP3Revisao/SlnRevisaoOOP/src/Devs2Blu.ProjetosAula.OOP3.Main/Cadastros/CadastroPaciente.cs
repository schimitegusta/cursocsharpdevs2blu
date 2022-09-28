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
            Paciente paciente = new Paciente();
            AlterarPaciente(paciente);
        }

        public void Exlcuir()
        {
            Paciente paciente = new Paciente();
            AlterarPaciente(paciente);
        }

        #region FACADE
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

        }
        private void ExcluirPaciente(Paciente paciente)
        {

        }
        #endregion
    }
}
