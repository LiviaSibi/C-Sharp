using System;

namespace Ex25
{
    class Program
    {
        static void Main(string[] args)
        {
            //*TODO: Resolver problema do vetor3 */
            Console.Clear();
            System.Console.WriteLine("**Gerando terceiro vetor**");
            System.Console.WriteLine();

            System.Console.Write("Diga o tamanho do primeiro vetor: ");
            int num1 = int.Parse(Console.ReadLine());
            int [] vetor1 = new int [num1];
            Random random1 = new Random();
            for(int i=0; i<num1; i++){
                vetor1[i] = random1.Next(1, 100);
            }

            System.Console.Write("Diga o tamanho do segundo vetor: ");
            int num2 = int.Parse(Console.ReadLine());
            int [] vetor2 = new int [num2];
            Random random2 = new Random();
            for(int i=0; i<num2; i++){
                vetor2[i] = random2.Next(1, 100);
            }

            int num3 = num1 + num2;
            int [] vetor3 =  new int [num3];
            vetor1.CopyTo(vetor3, 0);
            vetor2.CopyTo(vetor3, vetor1.Length);

            System.Console.WriteLine("Primeiro vetor: ");
            for(int i=0; i<num1; i++){
                System.Console.WriteLine((i+1) + "- " + vetor1[i]);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Segundo vetor: ");
            for(int i=0; i<num2; i++){
                System.Console.WriteLine((i+1) + "- " + vetor2[i]);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Terceiro vetor: ");
            for(int i=0; i<num3; i++){
                System.Console.WriteLine((i+1) + "- " + vetor3[i]);
            }
        }
    }
}
