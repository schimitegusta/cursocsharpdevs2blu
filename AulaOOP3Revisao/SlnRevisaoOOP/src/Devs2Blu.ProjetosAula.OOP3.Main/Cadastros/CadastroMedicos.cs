using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroMedicos
    {
        public void MenuCadastro()
        {
            Int32 opcao;
            do
            {
                Console.Clear();
                Console.WriteLine(" _____________________________________");
                Console.WriteLine("|          Cadastro de Medicos        |");
                Console.WriteLine("|-------------------------------------|");
                Console.WriteLine("|      1 -   Lista de Medicos         |");
                Console.WriteLine("|      2 - Cadastro de Medicos        |");
                Console.WriteLine("|      3 -   Alterar Medicos          |");
                Console.WriteLine("|-------------------------------------|");
                Console.WriteLine("|      0 -        VOLTAR              |");
                Console.WriteLine("|_____________________________________|");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarMedicos();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastrarMedico();
                        break;
                    default:
                        break;
                }
            } while (!opcao.Equals((int)MenuEnums.SAIR));
        }
        public void ListarMedicos()
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
        public void CadastrarMedico()
        {
            Console.Clear();

            string nome, cpf, especialidade;
            int crm;

            Console.Write($"Informe o Nome do Medico: ");
            nome = Console.ReadLine();
            Console.Write($"Informe o CPF do Medico: ");
            cpf = Console.ReadLine();
            Console.Write($"Informe o CRM do Medico: ");
            Int32.TryParse(Console.ReadLine(), out crm);
            Console.Write($"Informe a Especialidade do Medico: ");
            especialidade = Console.ReadLine();

            Random rd = new Random();
            Medico medico = new Medico(rd.Next(11, 100), nome, cpf, crm, especialidade);
            Program.Mock.ListaMedicos.Add(medico);
        }
        public void AlterarMedico()
        {

        }
        public void ExcluirMedico()
        {

        }
    }
}
