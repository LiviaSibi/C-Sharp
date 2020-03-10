using System;

namespace SomaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("***Soma de matriz aleatória***");
            System.Console.WriteLine();

            int[,] num = new int[3,3];
            Random random = new Random();

            for(int i=0;i<3;i++){
                for(int j=0;j<3;j++){
                    num[i, j]= random.Next(1, 100);
                }
            }
            int soma = num[0,0] + num[0,1] + num[1,0] + num[0,2] + num[2,0] + num[1,1] + num[1,2] + num[2,1] + num[2,2];
            System.Console.WriteLine($"A soma dos números da matriz será: {soma}");
        }
    }
}
