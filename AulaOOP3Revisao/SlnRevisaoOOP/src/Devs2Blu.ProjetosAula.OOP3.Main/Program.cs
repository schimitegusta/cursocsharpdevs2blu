using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Cadastros;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;

namespace Devs2Blu.ProjetosAula.OOP3.Main
{
    class Program
    {
        public static Mocks Mock { get; set; }
        static void Main(string[] args)
        {
            int opcao;
            Mock = new Mocks();
            do
            {
                Console.Clear();
                Console.WriteLine(" ________________________________________");
                Console.WriteLine("|       Sistema de Cadastro Clinico      |");
                Console.WriteLine("|________________________________________|");
                Console.WriteLine("|    10 -    Cadastro de Pacientes       |");
                Console.WriteLine("|    20 -     Cadastro de Medicos        |");
                Console.WriteLine("|    30 -  Cadastro de Recepcionistas    |");
                Console.WriteLine("|    40 -   Cadastro de Fornecedores     |");
                Console.WriteLine("|    50 -           Agenda               |");
                Console.WriteLine("|    60 -         Prontuario             |");
                Console.WriteLine("|    70 -         Financeiro             |");
                Console.WriteLine("|----------------------------------------|");
                Console.WriteLine("|    0 -             SAIR                |");
                Console.WriteLine("|________________________________________|");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.CAD_PAC:
                        CadastroPaciente ModuloCadastroPacientes = new CadastroPaciente();
                        ModuloCadastroPacientes.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_MED:
                        CadastroMedicos ModuloCadastroMedicos = new CadastroMedicos();
                        ModuloCadastroMedicos.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_REC:
                        CadastroRecepcionistas ModuloCadastroRecepcionistas = new CadastroRecepcionistas();
                        ModuloCadastroRecepcionistas.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_FOR:
                        CadastroFornecedores ModuloCadastroFornecedores = new CadastroFornecedores();
                        ModuloCadastroFornecedores.MenuCadastro();
                        break;
                    default:
                        break;
                }
            } while (!opcao.Equals((int)MenuEnums.SAIR)); 
        }
    }
}
