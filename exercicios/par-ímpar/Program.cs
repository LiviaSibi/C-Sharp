using System;

namespace parímpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            
            do{
                Console.Write("Digite um número ou 0 para encerrar: ");
                num = int.Parse(Console.ReadLine());

                if (num != 0){               
                    if (num % 2 == 0){
                        Console.WriteLine("Número par");
                    }

                    else {
                        Console.WriteLine("Número ímpar");
                    }
                }
            } while (num != 0);
        }
    }
}