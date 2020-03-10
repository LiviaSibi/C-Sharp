using System;

namespace IndiceMassa
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int peso;
            double altura;
            double imc;

            Console.Clear();
            System.Console.WriteLine("***Índice de Massa Corporal***");
            System.Console.WriteLine();

            System.Console.Write("Nome: ");
            nome = Console.ReadLine();
            System.Console.Write("Peso(Kg): ");
            peso = int.Parse(Console.ReadLine());
            System.Console.Write("Altura(m): ");
            altura = double.Parse(Console.ReadLine());

            imc = peso/(altura*altura);

            Paciente paciente1 = new Paciente(nome, peso, altura);

            System.Console.WriteLine();
            System.Console.WriteLine($"{nome}: {imc}");

            if(imc<20){
                System.Console.WriteLine("Faixa de Risco: Abaixo do peso.");
            }
            else if(imc>20 && imc <=25){
                System.Console.WriteLine("Faixa de Risco: Normal.");
            }
            else if(imc>25 && imc<=30){
                System.Console.WriteLine("Faixa de Risco: Exceso de peso.");
            }
            else if(imc>30 && imc<=35){
                System.Console.WriteLine("Faixa de Risco: Obesidade.");
            }
            else if (imc>35){
                System.Console.WriteLine("Faixa de Risco: Obesidade mórbida.");
            }

            System.Console.WriteLine();

        }
    }
}
