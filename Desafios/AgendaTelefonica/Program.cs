using System;
using System.IO;
using System.Collections.Generic;

namespace AgendaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            string nome;
            string telefone;
            string aniversario;

            List <Registro> registros = new List <Registro>();

            System.Console.WriteLine("===Cadastro===");
            System.Console.WriteLine();
            System.Console.Write("Nome: ");
            nome = Console.ReadLine();
            System.Console.Write("Telefone: ");
            telefone = Console.ReadLine();
            System.Console.Write("Aniversário: ");
            aniversario = Console.ReadLine();
            
            Registro registro1 = new Registro(nome, telefone, aniversario);
            registros.Add(registro1);

            System.Console.WriteLine("Seu cadastro foi feito com sucesso. Aperte ENTER para continuar.");
            Console.ReadLine();

            do{
                Console.Clear();
                System.Console.WriteLine("*************************");
                System.Console.WriteLine("    Agenda Telefonica    ");
                System.Console.WriteLine("*************************");
                System.Console.WriteLine();

                System.Console.WriteLine("1 - Cadastro");
                System.Console.WriteLine("2 - Atualização");
                System.Console.WriteLine("3 - Remoção de Registro");
                System.Console.WriteLine("4 - Buscar");
                System.Console.WriteLine("5 - Lista de Registros");
                System.Console.WriteLine("0 - Sair");
                System.Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                switch(opcao){
                    case "1":
                        Console.Clear();
                        System.Console.WriteLine("===Cadastro===");
                        System.Console.WriteLine();
                        System.Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        System.Console.Write("Telefone: ");
                        telefone = Console.ReadLine();
                        System.Console.Write("Aniversário: ");
                        aniversario = Console.ReadLine();
                        
                        Registro registro2 = new Registro(nome, telefone, aniversario);
                        registros.Add(registro2);

                        System.Console.WriteLine("Seu cadastro foi feito com sucesso. Aperte ENTER para continuar.");
                        Console.ReadLine();
                    break;

                    case "2":

                    break;

                    case "3":
                        System.Console.WriteLine();
                        System.Console.Write("Diga o nome registrado: ");
                        var apagar = Console.ReadLine();
                        int escolhido = 0;
                        for(int i = 0; i < registros.Count; i++){
                            if(apagar == registros[i]){
                                escolhido = i;
                            }
                        }
                    break;

                    case "4":
                        Console.Clear();
                    System.Console.WriteLine("*************************");
                    System.Console.WriteLine("    Agenda Telefonica    ");
                    System.Console.WriteLine("*************************");
                    System.Console.WriteLine();

                    ListaItensRegistro(registros);
                    break;

                    case "5":
                        System.Console.WriteLine();
                        System.Console.WriteLine("Lista de todos os usuarios: ");
                        System.Console.WriteLine($"{registro1.Nome}");
                        
                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para continuar.");
                        Console.ReadLine();
                        break;
                }
            }while(opcao != "0");
        }

        static List <Registro> initListRegistro (string filePathRegistro){
            List <Registro> registros= new List <Registro> ();

            try{
                string[] registroFile = File.ReadAllLines(@filePathRegistro);

                foreach(string line in registroFile){
                    string[] itens = line.Split(",");
                    Registro registroItem = new Registro();
                    registro.Add(registroItem);
                }
                registro.RemoveAt(0);
                return registro;
            }
            catch(IOException e){
                Console.WriteLine("Erro de Acesso");
                Console.WriteLine(e.Message);
                return null;
            } 
        }

        static void ListaItensRegistro (List <Registro> registro){
            Console.Clear();
            int count = 1;
            System.Console.WriteLine("==Lista de Registros==");
            System.Console.WriteLine();
            Console.WriteLine($"Nome{"",2} Telefone{"",12} Aniversário{"",7}");

            foreach(Registro item in registro){
                System.Console.WriteLine($"{count, 3}: {item.nome} - {item.Telefone} - {item.Aniversario}");
                count++;
            }
        }
    }
}
