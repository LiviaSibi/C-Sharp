using System;

namespace Alfabetica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("===Ordem Alfabética===");
            System.Console.WriteLine();

            string[] Nomes = new string[2];

            for (int i = 0; i < 2; i++){
                System.Console.Write($"Digite o {i+1}º nome: ");
                Nomes[i] = Console.ReadLine();
            }

            StringComparer pi = StringComparer.OrdinalIgnoreCase;
            Array.Sort(Nomes, pi);

            Console.Clear();
            System.Console.WriteLine("Em ordem alfabética: ");
            for (int i = 0; i < Nomes.Length; i++){
                System.Console.WriteLine(Nomes[i]);
            }
        }
    }
}
