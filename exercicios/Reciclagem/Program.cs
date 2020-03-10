using System;
using System.Collections.Generic;
using Reciclagem.Enum;
using Reciclagem.Models;
using Reciclagem.Interfaces;
using System.Linq;

namespace Reciclagem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;

            do{
                int codigo = -1;
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
                int.TryParse(Console.ReadLine(), out codigo);

                if(codigo >=1 || codigo <=6){
                    Reciclar(Lixeira.lixos[codigo]);
                }
                else{
                    querSair = true;
                }
            }while(!querSair);
        }

        public static void Reciclar (Lixo lixo){

            Type tipoLixo = lixo.GetType().GetInterfaces().FirstOrDefault();

            if (tipoLixo.Equals(typeof(IPapel))){
                IPapel lixoConvertido = (IPapel)lixo;
                System.Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine($"{lixoConvertido.LataAzul()} deve ir para a lixeira Azul");
                Console.ResetColor();
            }

            else if (tipoLixo.Equals(typeof(IMetal))){
                IMetal lixoConvertido = (IMetal)lixo;
                System.Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                System.Console.WriteLine($"{lixoConvertido.LataAmarela()} deve ir para a lixeira Amarela");
                Console.ResetColor();
            }

            else if (tipoLixo.Equals(typeof(IPlastico))){
                IPlastico lixoConvertido = (IPlastico)lixo;
                System.Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                System.Console.WriteLine($"{lixoConvertido.LataVermelha()} deve ir para a lixeira Vermelha");
                Console.ResetColor();
            }

            else if (tipoLixo.Equals(typeof(IVidro))){
                IVidro lixoConvertido = (IVidro)lixo;
                System.Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                System.Console.WriteLine($"{lixoConvertido.LataVerde()} deve ir para a lixeira Verde");
                Console.ResetColor();
            }

            else if (tipoLixo.Equals(typeof(INaoReciclavel))){
                INaoReciclavel lixoConvertido = (INaoReciclavel)lixo;
                System.Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine($"{lixoConvertido.LataCinza()} deve ir para a lixeira Cinza");
                Console.ResetColor();
            }

            else{
                System.Console.WriteLine();
                System.Console.WriteLine("Tipo não identificado!");
            }

            System.Console.WriteLine("Aperte ENTER para voltar ao menu principal");
            Console.ReadLine();
        }
    }
}
