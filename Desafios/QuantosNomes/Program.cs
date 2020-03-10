using System;
using System.IO;
using System.Collections.Generic;

namespace QuantosNomes
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Console.Clear();
            System.Console.WriteLine("==Quantidade de nomes digitados==");
            System.Console.WriteLine();

            List <string> nomes = new List <string>();
            string x;

            do{
                System.Console.Write("Diga um nome: ");
                nome = Console.ReadLine();
                System.Console.WriteLine("Aperte ENTER para continuar ou X para sair.");
                x = Console.ReadLine().ToLower();
                nomes.Add(nome);
            }while(x != "x");

            System.Console.WriteLine($"A quantidade de nomes digitada foi: {nomes.Count}");
            
        }
    }
}
