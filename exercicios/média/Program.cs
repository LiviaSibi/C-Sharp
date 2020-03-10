using System;

namespace média
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4;
            double media;

            Console.Write("Digite a primeira nota: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            num3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            num4 = double.Parse(Console.ReadLine());

            media = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine($"Média: {+media}");

            if (media >= 7.0){
                Console.WriteLine("APROVADO");
            }

            else {
                Console.WriteLine("REPROVADO");
            }
        }
    }
}
