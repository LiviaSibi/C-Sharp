using System;

namespace LimiteImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int limite;
            Console.Clear();
            System.Console.WriteLine("===A partir dos Limites - Impares===");
            System.Console.WriteLine();

            System.Console.Write("Diga um limite: ");
            limite = int.Parse(Console.ReadLine());

            for (int i=1; i<=limite; i+=2){
                System.Console.Write(i + " ");
            }
        }
    }
}
