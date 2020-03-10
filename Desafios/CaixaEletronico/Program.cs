using System;
using System.Collections.Generic;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            List<string> nota100 = new List<string>();
            List<string> nota50 = new List<string>();
            List<string> nota20 = new List<string>();
            List<string> nota10 = new List<string>();
            List<string> nota5 = new List<string>();
            List<string> nota2 = new List<string>();
            List<string> moedinha1 = new List<string>();

            int saque = 0;
            System.Console.WriteLine("============================");
            System.Console.WriteLine("    Bem vindo ao Caixa 2    ");
            System.Console.WriteLine("============================");
            System.Console.WriteLine();
            System.Console.Write("Digite o valor que deseja sacar: ");
            saque = int.Parse(Console.ReadLine());
            
            do{
                if ((saque - 100) >= 0){
                    saque -= 100;
                    nota100.Add("Nota de 100");
                } 
                else if ((saque - 50) >= 0){
                    saque -= 50;
                    nota50.Add("Nota de 50");
                } 
                else if ((saque - 20) >= 0){
                    saque -= 20;
                    nota20.Add("Nota de ");
                } 
                else if ((saque - 10) >= 0){
                    saque -= 10;
                    nota10.Add("nota");
                } 
                else if ((saque - 5) >= 0){
                    saque -= 5;
                    nota5.Add("nota");
                } 
                else if ((saque - 2) >= 0){
                    saque -= 2;
                    nota2.Add("nota");
                } 
                else if ((saque -1) >= 0){
                    saque -= 1;
                    moedinha1.Add("moeda");
                }
            } while (saque > 0);

            Console.Clear();
            System.Console.WriteLine("===================================================");

            if (nota100.Count > 0){
                System.Console.WriteLine($"         Você receberá {nota100.Count} nota(s) de 100");
            } 
            if (nota50.Count > 0) {
                System.Console.WriteLine($"         Você receberá {nota50.Count} nota(s) de  50");
            } 
            if (nota20.Count > 0){
                System.Console.WriteLine($"         Você receberá {nota20.Count} nota(s) de  20");
            } 
            if (nota10.Count > 0){
                System.Console.WriteLine($"         Você receberá {nota10.Count} nota(s) de  10");
            } 
            if (nota5.Count > 0){
                System.Console.WriteLine($"         Você receberá {nota5.Count} nota(s) de   5");
            } 
            if (nota2.Count > 0){
                System.Console.WriteLine($"         Você receberá {nota2.Count} nota(s) de   2");
            } 
            if (moedinha1.Count > 0){
                System.Console.WriteLine($"         Você receberá {moedinha1.Count} moeda(s) de  1");
            }
            System.Console.WriteLine("===================================================");
        }
    }
}
