using System;

namespace triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int quant;
            System.Console.Write("Diga a altura: ");
            a= int.Parse(Console.ReadLine());
            System.Console.Write("Diga a quantidade: ");
            quant= int.Parse(Console.ReadLine());

            for (int i =0; i<quant; i++){
                string estrelas = " ";
                for (int j=0; j<=a; j++){
                    estrelas += "*";
                    Console.WriteLine(estrelas);
                    }
                }
                Console.WriteLine();

        }
    }
}
