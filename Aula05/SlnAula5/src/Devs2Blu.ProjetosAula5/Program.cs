using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula5
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            Console.WriteLine("***** Aula 5 (Switch Case) *****\n\n");
            Console.WriteLine("Escolha uma atividade para executar: ");
            Console.WriteLine("-----------------");
            Console.WriteLine("1 - Exercicio 1");
            Console.WriteLine("2 - Exercicio 2");
            Console.WriteLine("3 - Exercicio 3");
            Console.WriteLine("21 - DESAFIO 21");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("-----------------");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "0":
                    break;
                case "1":
                    ExercicioSwitch1();
                    break;
                case "2":
                    ExercicioSwitch2();
                    break;
                case "3":
                    ExercicioSwitch3();
                    break;
                case "21":
                    Desafio21();
                    break;
                default:
                    break;
            }
        }
        static void ExercicioSwitch3()
        {
            Console.Clear();
            string tipoOperacao;
            int num1, num2, resultado = 0;

            Console.WriteLine("***** CALCULADORA *****");
            Console.WriteLine("Informe o tipo da operação ( + , - , / , * ): ");
            tipoOperacao = Console.ReadLine();
            Console.WriteLine("Informe o primeiro número: ");
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Informe o segundo número: ");
            Int32.TryParse(Console.ReadLine(), out num2);

            switch (tipoOperacao)
            {
                case "+":
                    resultado = num1 + num2;
                    tipoOperacao = "SOMA";
                    break;
                case "-":
                    resultado = num1 - num2;
                    tipoOperacao = "SUBTRAÇÃO";
                    break;
                case "/":
                    resultado = num1 / num2;
                    tipoOperacao = "DIVISÃO";
                    break;
                case "*":
                    resultado = num1 * num2;
                    tipoOperacao = "MULTIPLICAÇÃO";
                    break;
                default:
                    break;
            }
            Console.WriteLine("Resultado do calculo de " + tipoOperacao + ": " + resultado);
        }
        static void Desafio21()
        {
            Console.Clear();
            int jogador, jogador2, numAleatorio;

            Console.WriteLine("***** DESAFIO JOGO 21 *****");
            Console.Write("Informe um numero de 1 a 20: ");
            Int32.TryParse(Console.ReadLine(), out jogador);

            Random rnd = new Random();
            jogador2 = rnd.Next(1, 20);
            numAleatorio = rnd.Next(1, 20);

            if (jogador <= 0)
            {
                Console.WriteLine("Valor informado invalido!!!");
                return;
            } else if (jogador > 20)
            {
                Console.WriteLine("Valor acima do permitido!!!");
                return;
            }

            Console.WriteLine($"\nNumero gerado: {numAleatorio}\nNumero informado Jogador 1: {jogador}\nNumero gerado Jogador 2: {jogador2}\n");


            jogador = jogador + numAleatorio;
            jogador2 = jogador2 + numAleatorio;

            Console.WriteLine($"Valores somados:\nJogador 1: {jogador}\nJogador 2: {jogador2}\n");

            Console.WriteLine("RESULTADOS: \n");
            switch (jogador)
            {
                case 7:
                    Console.WriteLine("Jogador 1: 10 pontos");
                    break;
                case 14:
                    Console.WriteLine("Jogador 1: 20 pontos");
                    break;
                case 21:
                    Console.WriteLine("Jogador 1: 30 pontos");
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Jogador 1: 1 ponto");
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    Console.WriteLine("Jogador 1: 5 pontos");
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    Console.WriteLine("Jogador 1: 6 pontos");
                    break;
                default:
                    Console.WriteLine("Jogador 1: ZERO pontos ;-;");
                    break;
            }
            switch (jogador2)
            {
                case 7:
                    Console.WriteLine("Jogador 2: 10 pontos");
                    break;
                case 14:
                    Console.WriteLine("Jogador 2: 20 pontos");
                    break;
                case 21:
                    Console.WriteLine("Jogador 2: 30 pontos");
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Jogador 2: 1 ponto");
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    Console.WriteLine("Jogador 2: 5 pontos");
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    Console.WriteLine("Jogador 2: 6 pontos");
                    break;
                default:
                    Console.WriteLine("Jogador 2: ZERO pontos ;-;");
                    break;
            }

        }
        static void ExercicioSwitch2()
        {
            Console.Clear();
            string modeloVeiculo;

            Console.WriteLine("***** VENDA DE VEICULOS *****\n\n");
            Console.WriteLine("Opcoes de veiculos:");
            Console.WriteLine("----------------------");
            Console.WriteLine("HATCH");
            Console.WriteLine("SEDANS");
            Console.WriteLine("MOTOCICLETAS");
            Console.WriteLine("CAMINHONETES");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("----------------------");
            Console.WriteLine("Informe o veiculo que voce deseja comprar:");
            modeloVeiculo = Console.ReadLine();

            switch (modeloVeiculo.ToUpper())
            {
                case "0":
                    Console.WriteLine("Muito obrigado, volte sempre!");
                    break;
                case "HATCH":
                    Console.WriteLine("Compra efetuada com sucesso!");
                    break;
                case "SEDANS":
                case "MOTOCICLETAS":
                case "CAMINHONETES":
                    Console.WriteLine("Tem certeza que prefere este modelo?");
                    break;                
                default:
                    Console.WriteLine("Opcao de veiculo indisponivel!");
                    break;
            }
        }
        static void ExercicioSwitch1()
        {
            Console.Clear();
            string fruta;

            Console.WriteLine("Escolha uma fruta: ");
            Console.WriteLine("MAÇÃ - (Não vendemos)");
            Console.WriteLine("KIWI - (Sem estoque)");
            Console.WriteLine("MELANCIA - (Temos melancias)");
            fruta = Console.ReadLine();

            //fruta.ToUpper() serviria para deixar a variavel em caixa alta
            switch (fruta.ToUpper())
            {
                case "MAÇÃ":
                    Console.WriteLine("Não vendemos esta fruta aqui!");
                    break;
                case "KIWI":
                    Console.WriteLine("Estamos com escassez de kiwis!");
                    break;
                case "MELANCIA":
                    Console.WriteLine("Aqui está, são 3 reais o quilo!");
                    break;
                default:
                    Console.WriteLine("Fruta ou Item selecionado indisponivel!");
                    break;
            }
        }
        static void ExemploSwitch()
        {
            //-"A23" : Materiais
            //- "A35": Produtos Perecíveis
            //-"Z16": Produtos Químicos

            string codigo;

            Console.WriteLine("Escolha um produto para ver a descricao: ");
            Console.WriteLine("- A22");
            Console.WriteLine("- A23");
            Console.WriteLine("- A35");
            Console.WriteLine("- Z16");

            codigo = Console.ReadLine();

            switch (codigo)
            {
                case "A22":
                case "A23":
                    Console.WriteLine("A23: Materiais");
                    break;
                case "A35":
                    Console.WriteLine("A35: Produtos Pereciveis");
                    break;
                case "Z16":
                    Console.WriteLine("Z16: Produtos Quimicos");
                    break;
                default:
                    Console.WriteLine("Produto não cadastrado!");
                    break;
            }
        }
    }
}
