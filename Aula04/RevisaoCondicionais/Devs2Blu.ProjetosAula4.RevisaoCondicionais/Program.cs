using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Devs2Blu.ProjetosAula4.RevisaoCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AND == &&
            // OR == ||
            int option = 0;
            Console.WriteLine("Seja bem vindo ao programa Maluco!\n\n");
            Console.WriteLine("Escolha o problema desejado: ");
            Console.WriteLine("1 - Exercicio 1");
            Console.WriteLine("2 - Exercicio 2");
            Console.WriteLine("3 - Exercicio 3");
            Console.WriteLine("4 - Exercicio 4");
            Console.WriteLine("5 - Exercicio 5");
            Console.WriteLine("6 - Exercicio 6");
            Console.WriteLine("7 - Exercicio 7");
            Console.WriteLine("8 - Exercicio 8");
            Console.WriteLine("--------------");
            Console.WriteLine("0 - Sair");
            string optStr = Console.ReadLine();
            Int32.TryParse(optStr, out option);

            if (option == 1)
            {
                Exercicio1();
            }
            else if (option == 2)
            {
                Exercicio2();
            }
            else if (option == 3)
            {
                Exercicio3();
            }
            else if (option == 4)
            {
                Exercicio4();
            }
            else if (option == 5)
            {
                Exercicio5();
            }
            else if (option == 6)
            {
                Exercicio6();
            }
            else if (option == 7)
            {
                Exercicio7();
            }
            else if (option == 8)
            {
                Exercicio8();
            }
            else if (option == 0)
            {
                Console.WriteLine("Muito grato. Volte sempre! =D");
                return;
            }
            else
            {
                Console.WriteLine("Comando invalido!!!");
                return;
            }
        }
        static void Exercicio1()
        {
            // Limpa o Console
            Console.Clear();

            Console.WriteLine("***** Programa Exercicio 1  *****");
            Console.WriteLine("***** Gerar 2 Números Aleatórios (1 - 100) *****");
            Console.WriteLine("***** Mostrar o maior entre eles *****");
            int numero1, numero2;

            Random rd = new Random();
            numero1 = rd.Next(1, 100);
            numero2 = rd.Next(1, 100);

            Console.WriteLine($"Número 1 = {numero1}.");
            Console.WriteLine($"Número 2 = {numero2}.");

            if (numero1 < numero2)
            {
                Console.WriteLine($"Número 1 é o maior. Numero1 = {numero1}");
            }
            else if (numero2 < numero1)
            {
                Console.WriteLine($"Número 2 é o maior. Numero1 = {numero2}");
            }
            else
            {
                Console.WriteLine($"Os números são iguais! Números = {numero1}");
            }
        }
        static void Exercicio2()
        {
            Console.Clear();
            //n fiz
        }
        static void Exercicio3()
        {
            Console.Clear();
            Console.WriteLine("***** Programa Exercicio 3 *****");
            int number;

            Console.WriteLine("***** Descobrir se o numero e impar ou par! *****");
            Random rd = new Random();
            number = rd.Next(1, 100);

            if (number - number / 2 * 2 == 0)
            {
                Console.WriteLine($"O numero {number} e par!");
            }
            else
            {
                Console.WriteLine($"O numero {number} e impar!");
            }
        }
        static void Exercicio4()
        {
            Console.Clear();
            Console.WriteLine("***** Programa Exercicio 4 *****");
            string codigo;

            Console.WriteLine("Escolha um produto: ");
            Console.WriteLine("001 - Arroz");
            Console.WriteLine("002 - Feijao");
            Console.WriteLine("003 - Farinha");
            codigo = Console.ReadLine();

            if (codigo.Equals("001"))
            {
                Console.WriteLine("Produto informado e Arroz!");
            }
            else if (codigo.Equals("002"))
            {
                Console.WriteLine("Produto informado e Feijao!");
            }
            else if (codigo.Equals("003"))
            {
                Console.WriteLine("Produto informado e Farinha!");
            }
            else
            {
                Console.WriteLine("Diversos!");
                return;
            }
        }
        static void Exercicio5()
        {
            Console.Clear();
            int idade;
            bool permissao;
            string nome;

            Console.WriteLine("***** VERIFICAR SE VOCE PODE VOTAR ESSE ANO!!! *****\n\n");
            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Informe sua idade: ");
            string inputIdade = Console.ReadLine();
            Int32.TryParse(inputIdade, out idade);

            //Ternario
            permissao = (idade >= 16) ? true : false;

            if (permissao)
            {
                Console.WriteLine("Pode votar!");
            } else
            {
                Console.WriteLine("Nao pode votar!");
            }
        }
        static void Exercicio6()
        {
            Console.Clear();
            string nome,senha;
            const string SENHA_ACESSO = "1234", ACESSO_PERMITIDO = "Acesso Permitido!", ACESSO_NEGADO = "Acesso Negado!";

            Console.Write("***** TENTE ACESSAR O SISTEMA!!! *****\n\n");
            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Insira a senha do sistema: ");
            senha = Console.ReadLine();

            if (senha == SENHA_ACESSO)
            {
                Console.WriteLine("\nACESSO PERMITIDO");
                Console.WriteLine($"Ola {nome}, seja bem vindo(a)!\n");
            } else
            {
                Console.WriteLine("\nACESSO NEGADO, verifique se a senha esta correta!");
            }
        }
        static void Exercicio7()
        {
            Console.Clear();
            double precoApple;
            int qtdApple;

            Console.WriteLine("***** FEIRA DE MAÇÃS *****\n\n");
            Console.WriteLine("Preços: Menos que uma dúzia R$ 0,30");
            Console.WriteLine("Uma dúzia ou mais R$ 0,25\n");
            Console.Write("Informe a quantidade de maçãs que você deseja: ");
            string qtdAppleSTR = Console.ReadLine();
            Int32.TryParse(qtdAppleSTR, out qtdApple);

            if (qtdApple > 11)
            {
                precoApple = (qtdApple * 0.25);
            } else if (qtdApple < 12 && qtdApple > 0)
            {
                precoApple = (qtdApple * 0.30);
            } else
            {
                Console.WriteLine("Quantidade invalida de maçãs!");
                return;
            }
            Console.WriteLine($"\nValor da compra de {qtdApple} maçãs, R$ {precoApple}");
        }
        static void Exercicio8()
        {
            // Limpa o Console
            Console.Clear();

            Console.WriteLine("***** Programa Exercicio 2 *****");
            Console.WriteLine("***** Gerar 3 número aleatórios *****");
            Console.WriteLine("***** Escrevê-los em ordem crescente *****");
            int numero1, numero2, numero3;
            string formataSaida = "";

            Random rd = new Random();
            numero1 = rd.Next(1, 100);
            numero2 = rd.Next(1, 100);
            numero3 = rd.Next(1, 100);

            if (numero1 < numero2 &&
                numero1 < numero3)
            {
                formataSaida += $"{numero1}, ";
                if (numero2 < numero3)
                {
                    formataSaida += $"{numero2}, {numero3}";
                }
                else
                {
                    formataSaida += $"{numero3}, {numero2}";
                }
            }
            else if (numero2 < numero1 &&
                    numero2 < numero3)
            {
                formataSaida += $"{numero2}, ";
                if (numero1 < numero3)
                {
                    formataSaida += $"{numero1}, {numero3}";
                }
                else
                {
                    formataSaida += $"{numero3}, {numero1}";
                }
            }
            else
            {
                formataSaida += $"{numero3}, ";
                if (numero1 < numero2)
                {
                    formataSaida += $"{numero1}, {numero2}";
                }
                else
                {
                    formataSaida += $"{numero2}, {numero1}";
                }
            }

            Console.WriteLine($"Ordem crescente: {formataSaida}");
        }
    }

}

