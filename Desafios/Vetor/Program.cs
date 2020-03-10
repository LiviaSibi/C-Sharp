using System;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("===Crie um Vetor===");
            System.Console.WriteLine();

            int n;
            int [] vetor;
            System.Console.Write("Número de posições: ");
            n = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            vetor = new int[n];

            for (int i=0; i<n; i++){
                System.Console.Write($"Acrescente um número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine();
            System.Console.Write("Seu vetor é: ");
            
            foreach(int num in vetor){
                Console.Write($" {num}, ");
            }
        }
    }
}
