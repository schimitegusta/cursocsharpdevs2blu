using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Cadastros;
using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
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
            int opcao = 0, opcaoMenuCadastros = 0;
            Mock = new Mocks();
            IMenuCadastro menuCadastros;

            do
            {
                if (opcaoMenuCadastros.Equals((int)MenuEnums.SAIR))
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
                }

                switch (opcao)
                {
                    case (int)MenuEnums.CAD_PAC:
                        menuCadastros = new CadastroPaciente();
                        opcaoMenuCadastros = menuCadastros.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_MED:
                        menuCadastros = new CadastroMedicos();
                        opcaoMenuCadastros = menuCadastros.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_REC:
                        menuCadastros = new CadastroRecepcionistas();
                        opcaoMenuCadastros = menuCadastros.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_FOR:
                        menuCadastros = new CadastroFornecedores();
                        opcaoMenuCadastros = menuCadastros.MenuCadastro();
                        break;
                    default:
                        menuCadastros = new CadastroPadrao();
                        opcaoMenuCadastros = (int)MenuEnums.SAIR;
                        break;
                }

                switch (opcaoMenuCadastros)
                {
                    case (int)MenuEnums.LISTAR:
                        menuCadastros.Listar();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        menuCadastros.Cadastrar();
                        break;
                    case (int)MenuEnums.ALTERAR:
                        menuCadastros.Alterar();
                        break;
                    case (int)MenuEnums.EXCLUIR:
                        menuCadastros.Exlcuir();
                        break;
                    default:
                        opcaoMenuCadastros = (int)MenuEnums.SAIR;
                        break;
                }
            } while (!opcao.Equals((int)MenuEnums.SAIR));
        }
    }
}