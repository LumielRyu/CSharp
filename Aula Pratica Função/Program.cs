namespace Aula_Pratica_Função;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        bool isPrimo = VerificarPrimo(numero);

        if (isPrimo)
        {
            Console.WriteLine($"{numero} é um número primo.");
        }
        else
        {
            Console.WriteLine($"{numero} não é um número primo.");
        }
    }

    static bool VerificarPrimo(int numero)
    {
        if (numero <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}