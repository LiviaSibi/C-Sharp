using System;
using System.IO;
using System.Collections.Generic;
namespace SENAIzinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            string nome;
            string curso;
            int numeroSala;

            List <Aluno> alunos = new List <Aluno> ();
            string filePathAluno = "aluno.csv";
            alunos = initListAluno(@filePathAluno);

            List <Sala> salas = new List <Sala> ();
            string filePathSala = "sala.csv";
            salas = initListSala (@filePathSala);

            do{
                Console.Clear();
                System.Console.WriteLine("Bem-vindo ao SENAIzinho");
                System.Console.WriteLine();
                System.Console.WriteLine("1 - Cadastrar Aluno");
                System.Console.WriteLine("2 - Cadastrar Sala");
                System.Console.WriteLine("3 - Alocar Aluno");
                System.Console.WriteLine("4 - Remover Aluno");
                System.Console.WriteLine("5 - Verificar Salas");
                System.Console.WriteLine("6 - Verificar Alunos");
                System.Console.WriteLine("0 - Sair");
                System.Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());
                
                switch(opcao){
                    case 1:
                        if(alunos.Count < 100){
                            Console.Clear();
                            System.Console.Write("Nome do Aluno Completo: ");
                            nome = Console.ReadLine();
                            System.Console.Write("Data de Nascimento: ");
                            DateTime dataNasc = DateTime.Parse(Console.ReadLine());
                            System.Console.WriteLine("Curso: ");
                            curso = Console.ReadLine();
                            Aluno aluno1 = new Aluno ();
                            alunos.Add(aluno1);
                        }
                        else {
                            System.Console.WriteLine("Não há vagas");
                        }
                        break;

                    case 2:
                        if(salas.Count < 10){
                            Console.Clear();
                            System.Console.Write("Digite o número da sala: ");
                            numeroSala =int.Parse(Console.ReadLine());
                            Sala sala1 =new Sala();
                            salas.Add(sala1);
                        }
                        else{
                            System.Console.WriteLine("Não há mais espaço para salas");
                        }
                        break;

                    case 3:
                        Console.Clear();
                        System.Console.Write("Nome do Aluno Completo: ");
                        nome = Console.ReadLine();
                        System.Console.WriteLine("Sala que o aluno será alocado: ");
                        numeroSala = int.Parse(Console.ReadLine());

                        
                        break;

                    case 4:
                        int index = 0;
                        do{
                            Console.Clear();
                            System.Console.Write("Digite o ID do Aluno ou x para terminar");
                            System.Console.WriteLine("ID: ");
                            string id = Console.ReadLine();

                            if(id.ToLower() == "x"){
                                break;
                            }
                            else {
                                index = int.Parse(id) -1;
                            }

                            if((index < 0) || (index > alunos.Count -1)){
                                Console.WriteLine("ID inválido");
                                Console.WriteLine("Pressione <enter> para continuar");
                                Console.ReadLine();
                            }
                            else{
                                alunos.RemoveAt(index);
                            }
                            }while(true);
                        break;

                    case 5:
                        ListaItensSala(salas);
                        break;

                    case 6:
                        ListaItensAluno(alunos);
                        break;

                    case 0:
                        System.Console.WriteLine("Tchau!");
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        Console.ReadLine();
                        break;
                }
            }while(opcao!=0);
        }
    
        static List <Aluno> initListAluno (string filePathAluno){
            List <Aluno> aluno = new List <Aluno> ();

            try{
                string[] alunoFile = File.ReadAllLines(@filePathAluno);

                foreach(string line in alunoFile){
                    string[] itens = line.Split(",");
                    Aluno alunoItem = new Aluno();
                    aluno.Add(alunoItem);
                }
                aluno.RemoveAt(0);
                return aluno;
            }
            catch(IOException e){
                Console.WriteLine("Erro de Acesso");
                Console.WriteLine(e.Message);
                return null;
            } 
        }
    
        static List <Sala> initListSala (string filePathSala){
            List <Sala> sala = new List <Sala> ();

                try{
                    string[] salaFile = File.ReadAllLines(@filePathSala);

                    foreach(string line in salaFile){
                        string[] itens = line.Split(",");
                        Sala salaItem = new Sala();
                        sala.Add(salaItem);
                    }
                    sala.RemoveAt(0);
                    return sala;
                }
                catch(IOException e){
                    Console.WriteLine("Erro de Acesso");
                    Console.WriteLine(e.Message);
                    return null;
                } 
        }
    
        static void ListaItensAluno (List <Aluno> aluno){
            Console.Clear();
            int count = 1;
            System.Console.WriteLine("Lista de Alunos");
            System.Console.WriteLine();
            Console.WriteLine($"ID{"",2} Nome{"",12} Data de Nascimento{"",7} Nº Sala");

            foreach(Aluno item in aluno){
                System.Console.WriteLine($"{count, 3}: {item.nome} - {item.dataNasc} - {item.numeroSala}");
                count++;
            }
        }
    
        static void ListaItensSala (List <Sala> sala){
            Console.Clear();
            int count = 1;
            System.Console.WriteLine("Lista de Salas");
            System.Console.WriteLine();
            Console.WriteLine($"Capacidade Atual{"",2} Número Sala{"",12}");

            foreach(Sala item in sala){
                System.Console.WriteLine($"{count, 3}: {item.capacidadeAtual} - {item.numeroSala}");
                count++;
            }
        }
    }
}
