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
            Console.WriteLine("|      3 -   Alterar Medicos          |");
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
            Medico medico = new Medico();
            CadastrarMedico(medico);
        }

        public void Alterar()
        {
            Medico medico = new Medico();
            AlterarMedico(medico);
        }

        public void Exlcuir()
        {
            Medico medico = new Medico();
            ExcluirMedico(medico);
        }
        #region FACADE
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
            medico = new Medico(rd.Next(11, 100), nome, cpf, crm, especialidade);
            Program.Mock.ListaMedicos.Add(medico);
        }
        private void AlterarMedico(Medico medico)
        {

        }
        private void ExcluirMedico(Medico medico)
        {

        }
        #endregion
    }
}
