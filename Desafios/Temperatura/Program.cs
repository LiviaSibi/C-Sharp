using System;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double c;
            string x;

            do{
                Console.Clear();
                System.Console.WriteLine("**Convertor de Temperatura**");
                System.Console.WriteLine();
                System.Console.Write("Diga a temperatura em graus Celsius: ");
                c = double.Parse(Console.ReadLine());
                System.Console.WriteLine();
                System.Console.WriteLine($"Temperatura em Fahrenheit: ({c} * {9}/{5}) + {32} = {(c*9/5)+32}ºF");
                System.Console.WriteLine();
                System.Console.WriteLine("Aperte ENTER para continuar ou X para sair.");
                x = Console.ReadLine();
            }while(x.ToLower() != "x");
        }
    }
}
