using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroPaciente
    {
        public void MenuCadastro()
        {
            Int32 opcao;
            do
            {
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

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarPacientes();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastrarPaciente();
                        break;
                    default:
                        break;
                }
            } while (!opcao.Equals((int)MenuEnums.SAIR));
        }
        public void ListarPacientes()
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
        public void CadastrarPaciente()
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
            Paciente paciente = new Paciente(rd.Next(11, 100), nome, cpf, convenio);
            Program.Mock.ListaPacientes.Add(paciente);
        }
        public void AlterarPaciente()
        {

        }
        public void ExcluirPaciente()
        {

        }
    }
}
