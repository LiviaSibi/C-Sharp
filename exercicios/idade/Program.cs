using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;

            Console.Write("Digite sua idade: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Meses: {num1} * {12} = {num1 * 12}");
            Console.WriteLine($"Dias: {num1} * {365} = {num1 * 365}");
            Console.WriteLine($"Horas: {num1} * {8760} = {num1 * 8760}");
            Console.WriteLine($"Minutos: {num1} * {525600} = {num1 * 525600}");
        }
    }
}
