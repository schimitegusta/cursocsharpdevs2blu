using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula6.Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int controle = 0;

            do
            {
                Console.WriteLine("Informe um dos codigos abaixo: ");
                Console.WriteLine("1 - Exercicio1");
                Console.WriteLine("2 - Exercicio2");
                Console.WriteLine("3 - Exercicio3");
                Console.WriteLine("4 - Exercicio4");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("-------------");
                Int32.TryParse(Console.ReadLine(), out controle);

                switch (controle)
                {
                    case 0:
                        Console.WriteLine("Programa encerrado!");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    default:
                        Console.WriteLine("Valor invalido!");
                        break;
                }
            } while (controle > 0);

        }
        static void Exercicio4()
        {
            Console.Clear();
            int qtdAlunos, notas, mediaTurma = 0, i = 0;

            Console.WriteLine("*** MEDIA DE NOTAS DA SALA ***");
            Console.WriteLine("Informe uma quantidade de alunos: ");
            Int32.TryParse(Console.ReadLine(), out qtdAlunos);

            do
            {
                i++;
                Console.Write($"Informe a nota do aluno {i}: ");
                Int32.TryParse(Console.ReadLine(), out notas);
                mediaTurma = notas + mediaTurma;
            } while (i != qtdAlunos);

            mediaTurma = mediaTurma / qtdAlunos;

            Console.WriteLine($"\nMedia de nota da turma é: {mediaTurma}");
            Console.ReadKey();
            Console.Clear();
        }
        static void Exercicio3()
        {
            Console.Clear();
            int i = 0, num = 0;

            Console.WriteLine("*** NUMEROS PARES E IMPARES ***\n");
            Console.WriteLine("Informe um numero desejado: ");
            Int32.TryParse(Console.ReadLine(), out num);

            Console.WriteLine("Numeros PARES :\n");

            while (i != num)
            {
                i++;
                if (i - i / 2 * 2 == 0)
                {
                    Console.Write($" {i} |");
                }
            }
            i = 0;

            Console.WriteLine($"\n\nNumeros IMPARES:\n");

            while (i != num)
            {
                i++;
                if (i - i / 2 * 2 != 0)
                {
                    Console.Write($" {i} |");
                }
            }

            Console.ReadKey();
            Console.Clear();
        }
        static void Exercicio2()
        {
            Console.Clear();
            int num = 0;
            Console.WriteLine("*** NUMEROS PARES ATE 100 ***");

            do
            {
                num = num + 1;
                if (num - num / 2 * 2 == 0)
                {
                    Console.Write($"{num}, ");
                }
            } while (num < 100);
            Console.ReadKey();
            Console.Clear();
        }
        static void Exercicio1()
        {
            Console.Clear();
            int num = 0;
            Console.WriteLine("*** NUMEROS IMPARES ATE 100***");

            do
            {
                num = num + 1;
                if (num - num / 2 * 2 != 0)
                {
                    Console.Write($"{num}, ");
                }
            } while (num < 100);
            Console.ReadKey();
            Console.Clear();
        }

    }
}
