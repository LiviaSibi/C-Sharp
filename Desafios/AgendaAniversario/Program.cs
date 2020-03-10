using System;
using System.IO;
using System.Collections.Generic;

namespace AgendaAniversario
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> Nomes = new List<string>();
            List <string> Niver = new List<string>();

            int opcao;
            string nome;
            string niver;
            string apagar;

            do{
                Console.Clear();
                System.Console.WriteLine("==========================");
                System.Console.WriteLine("  Agenda de Aniversários  ");
                System.Console.WriteLine("==========================");
                System.Console.WriteLine();

                System.Console.WriteLine("1 - Cadastrar");
                System.Console.WriteLine("2 - Excluir");
                System.Console.WriteLine("3 - Buscar Nome");
                System.Console.WriteLine("4 - Lista de aniversários");
                System.Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao){
                    case 1:
                        System.Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        Nomes.Add(nome);
                        System.Console.Write("Aniversário: ");
                        niver = Console.ReadLine();
                        Niver.Add(niver);
                        System.Console.WriteLine();
                        System.Console.WriteLine("Usuário foi adicionado");
                        System.Console.WriteLine("Aperte ENTER para continuar.");
                        Console.ReadLine();
                        break;

                    case 2:
                        System.Console.Write("Diga o nome do usuário que será excluido: ");
                        apagar = Console.ReadLine();
                        int escolhido = 0;
                        for(int i = 0; i < Nomes.Count; i++){
                            if(apagar == Nomes[i]){
                                escolhido = i;
                            }
                        }
                        Nomes.RemoveAt(escolhido);
                        Niver.RemoveAt(escolhido);
                        System.Console.WriteLine();
                        System.Console.WriteLine("Usuário foi excluído.");
                        System.Console.WriteLine("Aperte ENTER para continuar.");
                        Console.ReadLine();
                        break;

                    case 3:
                        System.Console.WriteLine("Digite o nome do usuario a ser encontrado: ");
                        string encontrar = Console.ReadLine();
                        int numeroencontrar = 0;
                        for(int i = 0; i < Nomes.Count; i++){
                            if(encontrar == Nomes[i]){
                                numeroencontrar = i;
                                
                            }
                        }
                            System.Console.WriteLine();
                            System.Console.WriteLine("Usuario encontrado: ");
                            System.Console.WriteLine("Nome: " + encontrar);
                            System.Console.WriteLine("Data de aniversario: " + Niver[numeroencontrar]);
                            System.Console.WriteLine();
                            System.Console.WriteLine("Aperte ENTER para continuar.");
                            Console.ReadLine();
                        break;

                    case 4:
                        System.Console.WriteLine();
                        System.Console.WriteLine("Lista de todos os usuarios: ");
                        for(int i = 0; i < Nomes.Count; i++){
                            System.Console.WriteLine(Nomes[i]);
                        }
                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para continuar.");
                        Console.ReadLine();
                        break;

                    case 0:
                    System.Console.WriteLine("Tchau!");
                        break;
                }
            }while(opcao != 0);
        }
    }
}
