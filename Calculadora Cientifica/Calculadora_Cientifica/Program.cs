using System;

namespace CalculadoraCientifica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo à Calculadora Científica!");

            while (true)
            {
                Console.WriteLine("\nEscolha a operação:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Potenciação");
                Console.WriteLine("6 - Raiz Quadrada");
                Console.WriteLine("7 - Seno");
                Console.WriteLine("8 - Cosseno");
                Console.WriteLine("9 - Tangente");
                Console.WriteLine("0 - Sair");

                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 0)
                    break;

                double num1 = 0, num2 = 0;

                if (opcao >= 1 && opcao <= 5)
                {
                    Console.Write("Digite o primeiro número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }
                else if (opcao >= 6 && opcao <= 9)
                {
                    Console.Write("Digite o número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                }

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"Resultado: {Adicionar(num1, num2)}");
                        break;
                    case 2:
                        Console.WriteLine($"Resultado: {Subtrair(num1, num2)}");
                        break;
                    case 3:
                        Console.WriteLine($"Resultado: {Multiplicar(num1, num2)}");
                        break;
                    case 4:
                        Console.WriteLine($"Resultado: {Dividir(num1, num2)}");
                        break;
                    case 5:
                        Console.WriteLine($"Resultado: {Potencia(num1, num2)}");
                        break;
                    case 6:
                        Console.WriteLine($"Resultado: {RaizQuadrada(num1)}");
                        break;
                    case 7:
                        Console.WriteLine($"Resultado: {Seno(num1)}");
                        break;
                    case 8:
                        Console.WriteLine($"Resultado: {Cosseno(num1)}");
                        break;
                    case 9:
                        Console.WriteLine($"Resultado: {Tangente(num1)}");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        static double Adicionar(double a, double b)
        {
            return a + b;
        }

        static double Subtrair(double a, double b)
        {
            return a - b;
        }

        static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Erro: Divisão por zero!");
                return double.NaN;
            }
            return a / b;
        }

        static double Potencia(double a, double b)
        {
            return Math.Pow(a, b);
        }

        static double RaizQuadrada(double a)
        {
            if (a < 0)
            {
                Console.WriteLine("Erro: Raiz quadrada de número negativo!");
                return double.NaN;
            }
            return Math.Sqrt(a);
        }

        static double Seno(double a)
        {
            return Math.Sin(a);
        }

        static double Cosseno(double a)
        {
            return Math.Cos(a);
        }

        static double Tangente(double a)
        {
            return Math.Tan(a);
        }
    }
}
