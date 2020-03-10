using System;

namespace Planetas
{
    class Program
    {
        static void Main(string[] args)
        {

            int peso;
            int planeta;
            string x;

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("*****************************");
            System.Console.WriteLine(" Seu peso em outros planetas ");
            System.Console.WriteLine("*****************************");
            Console.ResetColor();
            System.Console.WriteLine();

            System.Console.Write("Diga seu peso na Terra: ");
            peso = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            do{
                Console.Clear();
                System.Console.WriteLine("Digite o número de um Planeta: ");
                System.Console.WriteLine("1 - Mercúrio");
                System.Console.WriteLine("2 - Vênus");
                System.Console.WriteLine("3 - Marte");
                System.Console.WriteLine("4 - Júpiter");
                System.Console.WriteLine("5 - Saturno");
                System.Console.WriteLine("6 - Urano");
                planeta = int.Parse(Console.ReadLine());

                switch(planeta){
                    case 1:
                        System.Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Console.WriteLine($"Seu peso em Mercúrio é: {(peso/10)*0.37}");
                        Console.ResetColor();
                        break;

                    case 2:
                        System.Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.ForegroundColor = ConsoleColor.Black;
                        System.Console.WriteLine($"Seu peso em Vênus é: {(peso/10)*0.88}");
                        Console.ResetColor();
                        break;

                    case 3:
                        System.Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Console.WriteLine($"Seu peso em Marte é: {(peso/10)*0.38}");
                        Console.ResetColor();
                        break;

                    case 4:
                        System.Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Console.WriteLine($"Seu peso em Júpiter é: {(peso/10)*2.64}");
                        Console.ResetColor();
                        break;

                    case 5:
                        System.Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        System.Console.WriteLine($"Seu peso em Saturno é: {(peso/10)*1.15}");
                        Console.ResetColor();
                        break;

                    case 6:
                        System.Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Console.WriteLine($"Seu peso em Urano é: {(peso/10)*1.17}");
                        Console.ResetColor();
                        break;
                }
                System.Console.WriteLine();
                System.Console.WriteLine("Aperte ENTER para continuar ou X para sair.");
                x = Console.ReadLine();
            }while(x != "x");
        }
    }
}
