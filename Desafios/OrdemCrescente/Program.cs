using System;

namespace OrdemCrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;

            Console.Clear();
            System.Console.WriteLine("===Ordem Crescente===");
            System.Console.WriteLine();

            System.Console.Write("Diga o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            System.Console.Write("Diga o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            System.Console.Write("Diga o terceiro número: ");
            num3 = int.Parse(Console.ReadLine());

            if((num1>num2) && (num1>num3) && (num2>num3)){
                System.Console.WriteLine($"{num3} < {num2} < {num1}");
            }

            else if((num2>num1) && (num2>num3) && (num1>num3)){
                System.Console.WriteLine($"{num3} < {num1} < {num2}");
            }

            else if((num2>num1) && (num2>num3) && (num3>num1)){
                System.Console.WriteLine($"{num1} < {num3} < {num2}");
            }

            else if((num3>num2) && (num3>num1) && (num2>num1)){
                System.Console.WriteLine($"{num1} < {num2} < {num3}");
            }

            else if((num1>num2) && (num1>num3) && (num3>num2)){
                System.Console.WriteLine($"{num2} < {num3} < {num1}");
            }

            else if((num3>num2) && (num3>num1) && (num1>num2)){
                System.Console.WriteLine($"{num2} < {num1} < {num3}");
            }
        }
    }
}
