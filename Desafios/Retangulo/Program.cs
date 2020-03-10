using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double b;
            double a;
            string x;

            do{
                Console.Clear();
                System.Console.WriteLine("###### Retângulo ######");
                System.Console.WriteLine();
                System.Console.Write("Diga a base do retângulo: ");
                b = double.Parse(Console.ReadLine());
                System.Console.Write("Diga a altura do retêngulo: ");
                a = double.Parse(Console.ReadLine());
                System.Console.WriteLine();
                
                System.Console.WriteLine($"Perímetro = {2*a + 2*b}");
                System.Console.WriteLine($"Área = {b*a}");
                double r = Math.Sqrt ((a*a) + (b*b));
                System.Console.WriteLine($"Diagonal = {r}");
                System.Console.WriteLine();
                System.Console.WriteLine("Aperte ENTER para continuar ou X para sair.");
                x = Console.ReadLine();
            }while(x.ToLower() != "x");
        }
    }
}
