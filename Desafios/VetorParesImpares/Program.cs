using System;
using System.IO;
using System.Collections.Generic;

namespace VetorParesImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("**Pares e ímpares de um vetor**");
            System.Console.WriteLine();

            int [] vetor = new int [10];
            Random num = new Random();

            for(int i=0; i<10; i++){
                vetor[i] = num.Next(1, 100);
            }
            
            List<int> Pares = new List<int>();
            List<int> Impares = new List<int>();
            
            for(int j=0; j<10; j++){
                if(vetor[j] % 2 == 0){
                    Pares.Add(vetor[j]);
                }
                else{
                    Impares.Add(vetor[j]);
                }
            }

            System.Console.WriteLine("Números pares: ");
            foreach(int n in Pares){
                System.Console.Write($"{n}, ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Números impares: ");
            foreach(int n in Impares){
                System.Console.Write($"{n}, ");
            }
        }
    }
}
