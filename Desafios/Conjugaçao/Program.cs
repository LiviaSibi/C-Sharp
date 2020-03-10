using System;

namespace Conjugaçao
{
    class Program
    {
        static void Main(string[] args)
        {
            string verbo;
            string infinitivo1 = "ar";
            string infinitivo2 = "er";
            string infinitivo3 = "ir";

            bool conj1;
            bool conj2;
            bool conj3;
            
            Console.Clear();
            System.Console.WriteLine("====Verbo no Infinitivo====");
            System.Console.WriteLine();

            System.Console.Write("Diga um verbo: ");
            verbo = Console.ReadLine();
            System.Console.WriteLine();
            
            conj1 = verbo.Contains(infinitivo1);
            conj2 = verbo.Contains(infinitivo2);
            conj3 = verbo.Contains(infinitivo3);

            if (conj1){
                System.Console.WriteLine("Esse verbo é da primeira conjugação.");
            } 
            else if (conj2){
                System.Console.WriteLine("Esse verbo é da segunda conjugação");
            } 
            else if (conj3){
                System.Console.WriteLine("Esse verbo é da terceira conjugação");
            } 
            else {
                System.Console.WriteLine("Esse verbo não está no infinitivo.");
            }
            
        }
    }
}
