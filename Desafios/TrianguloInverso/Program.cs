using System;

namespace TrianguloInverso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("===Triângulo Inverso===");
            System.Console.WriteLine();

            int a;
            System.Console.Write("Diga a altura: ");
            a= int.Parse(Console.ReadLine());

            for (int i=0; i<=a; i++){
                for(int j=i;j<a;j++){
                    Console.Write("*");
                }
            Console.WriteLine("");
            }
        }
    }
}
