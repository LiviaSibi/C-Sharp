using System;
using System.Collections.Generic;

namespace VetorMaiorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int menor = 0;
            int maior = 0;
            int posicaoMenor = 0;
            int posicaoMaior = 0;

            Console.Clear();
            System.Console.WriteLine("*** Maiores e menores números de um vetor ***");
            System.Console.WriteLine();

            int [] vetor = new int [10];
            Random random = new Random();

            for(int i=0; i<10; i++){
                vetor[i] = random.Next(1, 100);
            }

            System.Console.WriteLine("Lista de números: ");
            foreach(int n in vetor){
                System.Console.Write(n + ", ");
            }

            menor = vetor[0];
            maior = vetor[0];

            for(int i=0; i<10; i++){
                if(vetor[i]< menor){
                    menor = vetor[i];
                    posicaoMenor = i;
                }
                else if(vetor[i]>maior){
                    maior = vetor[i];
                    posicaoMaior = i;
                } 
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Posição do maior número: {posicaoMaior + 1}");
            System.Console.WriteLine($"Posição do menor número: {posicaoMenor + 1}");
        }
    }
}
