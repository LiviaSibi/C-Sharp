using System;

namespace ReciclagemSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            do{
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("=======================");
                System.Console.WriteLine("       Reciclagem      ");
                System.Console.WriteLine("=======================");
                Console.ResetColor();
                System.Console.WriteLine();
                System.Console.WriteLine("1 - Garrafa de Vidro");
                System.Console.WriteLine("2 - Garrafa PET");
                System.Console.WriteLine("3 - Guarda Chuva");
                System.Console.WriteLine("4 - Latinha");
                System.Console.WriteLine("5 - Papelão");
                System.Console.WriteLine("6 - Pote de Manteiga");
                System.Console.WriteLine("0 - Sair");
                System.Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                switch(opcao){
                    case "1":
                    System.Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("Jogue na Lata de Lixo Verde");
                    Console.ResetColor();
                    System.Console.Write("Aperte ENTER para prosseguir");
                    Console.ReadLine();
                    break;

                    case "2":
                    System.Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("Jogue na Lata de Lixo Vermelha");
                    Console.ResetColor();
                    System.Console.Write("Aperte ENTER para prosseguir");
                    Console.ReadLine();
                    break;

                    case "3":
                    System.Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Console.WriteLine("Jogue na Lata de Lixo Cinza");
                    Console.ResetColor();
                    System.Console.Write("Aperte ENTER para prosseguir");
                    Console.ReadLine();
                    break;

                    case "4":
                    System.Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("Jogue na Lata de Lixo Amarela");
                    Console.ResetColor();
                    System.Console.Write("Aperte ENTER para prosseguir");
                    Console.ReadLine();
                    break;

                    case "5":
                    System.Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Console.WriteLine("Jogue na Lata de Lixo Azul");
                    Console.ResetColor();
                    System.Console.Write("Aperte ENTER para prosseguir");
                    Console.ReadLine();
                    break;

                    case "6": 
                    System.Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("Jogue na Lata de Lixo Vermelha");
                    Console.ResetColor();
                    System.Console.Write("Aperte ENTER para prosseguir");
                    Console.ReadLine();
                    break;

                    case "0":
                    System.Console.WriteLine();
                    System.Console.WriteLine("Obrigada por Reciclar ;)");
                    break;

                    default:
                    System.Console.WriteLine();
                    System.Console.WriteLine("Codigo Desconhecido");
                    System.Console.Write("Aperte ENTER para prosseguir");
                    Console.ReadLine();
                    break;
                }
            }while(opcao != "0");
        }
    }
}
