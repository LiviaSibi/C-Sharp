using System;

namespace Meses
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes;
            string x;
            do{
                Console.Clear();
                System.Console.WriteLine("****Meses do Ano****");
                System.Console.WriteLine();

                System.Console.Write("Diga um número de 1 a 12: ");
                mes = int.Parse(Console.ReadLine());
                System.Console.WriteLine();

                switch(mes){
                    case 1:
                        System.Console.WriteLine("Mês 1: Janeiro");
                        break;

                    case 2:
                        System.Console.WriteLine("Mês 2: Fevereiro");
                        break;

                    case 3:
                        System.Console.WriteLine("Mês 3: Março");
                        break;

                    case 4:
                        System.Console.WriteLine("Mês 4: Abril");
                        break;

                    case 5:
                        System.Console.WriteLine("Mês 5: Maio");
                        break;

                    case 6:
                        System.Console.WriteLine("Mês 6: Junho");
                        break;

                    case 7:
                        System.Console.WriteLine("Mês 7: Julho");
                        break;

                    case 8:
                        System.Console.WriteLine("Mês 8: Agosto");
                        break;

                    case 9:
                        System.Console.WriteLine("Mês 9: Setembro");
                        break;

                    case 10:
                        System.Console.WriteLine("Mês 10: Outubro");
                        break;

                    case 11:
                        System.Console.WriteLine("Mês 11: Novembro");
                        break;

                    case 12:
                        System.Console.WriteLine("Mês 12: Dezembro");
                        break;

                    default:
                        System.Console.WriteLine("Não existe mês com esse número.");
                        break;
                }

                System.Console.WriteLine();
                System.Console.WriteLine("Aperte ENTER para continuar ou X para sair.");
                x = Console.ReadLine();
            }while(x!="x");
        }
    }
}
