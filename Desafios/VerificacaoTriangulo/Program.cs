using System;

namespace VerificacaoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;

            Console.Clear();
            System.Console.WriteLine("====Verificação Triângulo====");
            System.Console.WriteLine();

            System.Console.Write("Diga o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            System.Console.Write("Diga o segundo número: ");
            num2= int.Parse(Console.ReadLine());
            System.Console.Write("Diga o terceiro número: ");
            num3 = int.Parse(Console.ReadLine());

            if (((num1+num2)>num3) && ((num2+num3)>num1) && ((num1+num3)>num2)){
                if ((num1==num2)&&(num2==num3)&&(num3==num1)){
                    System.Console.WriteLine("Triângulo Equilatero");
                }
                else if(num1==num2 || num2==num3 || num1==num3){
                    System.Console.WriteLine("Triêngulo Isósceles");
                }
                else if((num1!=num2)&&(num2!=num3)&&(num3!=num1)){
                    System.Console.WriteLine("Triêngulo Escaleno");
                }
            }
            else{
                System.Console.WriteLine("Os lados escolhidos não fazem parte de um triângulo.");
            }
        }
    }
}
