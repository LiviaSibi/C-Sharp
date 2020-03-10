using System;

namespace faixa_etária
{
    class Program
    {
        static void Main(string[] args)
        {
            int atual = 2019;
            int ano = 0;
            int faixa;

            Console.Write("Em que ano você nasceu? ");
            ano = int.Parse(Console.ReadLine());

            faixa = atual - ano;
            Console.WriteLine("Sua idade atual é de " + faixa + " anos");

            if (faixa<=2){
                Console.WriteLine("Classificado como Recém-nascido");
            }

            else if ((faixa >= 3) && (faixa <= 11)) {
                Console.WriteLine("Classificado como Criança");
            }

            else if ((faixa>=12) && (faixa <= 19)){
                Console.WriteLine("Classificado como Adolescente");
            } 

            else if ((faixa >= 20) && (faixa <= 65)){
                Console.WriteLine("Classificado como Adulto");
            }

            else if (faixa > 65) {
                Console.WriteLine("Classificado como Idoso");
            }
        }
    }
}
