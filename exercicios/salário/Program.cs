using System;

namespace salário
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double salario;

            Console.Write("Digite seu salário: ");
            num1 = double.Parse(Console.ReadLine());

            salario = num1 * 1.3;

            if (num1 < 500) {
                Console.WriteLine("Parabéns, você ganhou um aumento");
                Console.WriteLine($"Novo Salário: R${salario:F2}");
            }

            else {
                Console.WriteLine("Desculpe, você não possui direito ao aumento salarial");
            }
        }
    }
}
