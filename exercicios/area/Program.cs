using System;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1;
            double b2;
            double h;
            double pi = 3.14;
            string x;

            do{
            Console.WriteLine("Escolha uma das opções: ");
            Console.WriteLine("Digite a para Quadrado");
            Console.WriteLine("Digite b para Triângulo");
            Console.WriteLine("Digite c para Círculo");
            Console.WriteLine("Digite d para Trapézio");
            Console.WriteLine("Digite e para Retângulo");
            Console.WriteLine("Digite f para Losango");
            x=Console.ReadLine();

            switch (x){
                case "a":
                    Console.Write("Diga o lado: ");
                    b1=double.Parse(Console.ReadLine());
                    Console.WriteLine($"Área: {b1} * {b1} = {b1*b1}");
                    break;

                case "b":
                    Console.Write("Diga a base: ");
                    b1=double.Parse(Console.ReadLine());
                    Console.Write("Diga a altura: ");
                    h=double.Parse(Console.ReadLine());
                    Console.WriteLine($"Área: {b1} * {h} / {2} = {b1*h/2}");
                    break;

                case "c":
                    Console.Write("Diga o raio: ");
                    b1=double.Parse(Console.ReadLine());
                    Console.WriteLine($"Área: {b1} * {b1} * {pi} = {b1*b1*pi}");
                    break;

                case "d":
                    Console.Write("Diga a base maior: ");
                    b1=double.Parse(Console.ReadLine());
                    Console.Write("Diga a base menor: ");
                    b2=double.Parse(Console.ReadLine());
                    Console.Write("Diga a altura: ");
                    h=double.Parse(Console.ReadLine());
                    Console.WriteLine($"Área: ({b1} + {b2}) * {h} / {2} = {(b1+b2)*h/2}");
                    break;

                case "e":
                    Console.Write("Diga a base: ");
                    b1=double.Parse(Console.ReadLine());
                    Console.Write("Diga a altura: ");
                    h=double.Parse(Console.ReadLine());
                    Console.WriteLine($"Área: {b1} * {h} = {b1*h}");
                    break;

                case "f":
                    Console.Write("Diga a diagonal maior: ");
                    b1=double.Parse(Console.ReadLine());
                    Console.Write("Diga a diagonal menor: ");
                    b2=double.Parse(Console.ReadLine());
                    Console.WriteLine($"Área: {b1} * {b2} / {2} = {b1*b2/2}");
                    break;
                }
            
            } while (x!="fim");
        }
    }
}
