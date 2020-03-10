using System;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Clear();
            System.Console.WriteLine("***Troca de Variáveis***");
            System.Console.WriteLine();
            System.Console.Write("Diga a variável A: ");
            a= int.Parse(Console.ReadLine());
            System.Console.Write("Diga a variável B: ");
            b= int.Parse(Console.ReadLine());
            
            a += b;
            b = a - b;
            a -= b;
            System.Console.WriteLine();
            System.Console.WriteLine($"Novas variáveis:   A={a}  B={b}");
        }
    }
}
