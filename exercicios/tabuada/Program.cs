using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a<= 10; a++){
                for (int b=1; b<=10; b++){
                    Console.Write($"{b} * {a} = {b*a}\t");
                }
                Console.WriteLine();
            }
        }
    }
}

