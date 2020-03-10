using System;

namespace Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora;
            double velocidade;
            double distancia = 0.0;
            string x;

            do{
                Console.Clear();
                System.Console.WriteLine("***Gasto de Combustível***");
                System.Console.WriteLine();
                System.Console.Write("Diga a velocidade média em Km/h: ");
                velocidade = double.Parse(Console.ReadLine());
                System.Console.Write("Diga quantas horas de viagem: ");
                hora = int.Parse(Console.ReadLine());

                System.Console.WriteLine($"Tempo de viagem: {hora}h ");
                System.Console.WriteLine($"Sua velocidade média foi de {velocidade}Km/h");
                System.Console.WriteLine();
                distancia = velocidade*hora;
                System.Console.WriteLine($"A distância percorrida foi de {distancia}Km");
                System.Console.WriteLine($"Foram usados na viagem {distancia/12} litros de combustível.");
                
                System.Console.WriteLine();
                System.Console.WriteLine("Aperte ENTER para continuar ou X para sair.");
                x = Console.ReadLine();

            }while(x.ToLower() != "x");
            
        }
    }
}
