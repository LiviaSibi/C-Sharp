using System;
using System.Linq;
using ZooLogico.Interfaces;
using ZooLogico.Models.Animais;
using ZooLogico.Models.Habitats;
using System.Collections.Generic;

namespace ZooLogico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Variável de controle do Loop Principal
            var encerrouPrograma = false;
            #region Loop Principal
            do
            {
                #region Menu Principal
                var codigo = 0;
                Console.Clear();
                System.Console.WriteLine("===============================");
                System.Console.WriteLine("|   Bem-vindo ao Zoo Lógico!  |");
                System.Console.WriteLine("===============================");
                
                foreach (var item in Arca.Animais.Values){
                    System.Console.WriteLine($"{"",5}{++codigo}. {item.GetType().Name}");
                }
                #endregion
                System.Console.Write($"\n{"",2}Digite o código do animal: ");
                
                try{
                    int opcaoUsuario = int.Parse(Console.ReadLine());
                    var animal = Arca.Animais[opcaoUsuario];
                    ClassificarAnimal(animal);
                }
                catch (Exception e){
                    System.Console.WriteLine("Por favor, digite um código válido");
                    Console.ReadLine();
                }

            } while (!encerrouPrograma);
            #endregion
        }

        public static void ClassificarAnimal(Animal animal)
        {
            // Esse @ é para que possamos usar o nome interface para a variável, que é uma palavra reservada do C#!
            var classe = animal.GetType();
            var @interface = classe.GetInterfaces().FirstOrDefault();
            string alocar;
            List <Animal> piscina = new List <Animal>();
            List <Animal> casaArvore =  new List<Animal>();
            List <Animal> aquario = new List<Animal>();
            List <Animal> aquarioGelados = new List<Animal>();
            List <Animal> cavernaPedras = new List<Animal>();
            List <Animal> gaiola = new List<Animal>();

            if ((typeof(IAquatico)).Equals(@interface)){
                System.Console.WriteLine($":::{classe.Name} pode ir para a Piscina:::");
                System.Console.Write($"Alocar {classe.Name} na Piscina? S/N  ");
                alocar = Console.ReadLine().ToLower();
                    if ((alocar == "s") && (piscina.Count <= 3)){
                        piscina.Add(animal);
                        System.Console.WriteLine("O animal foi alocado");
                    }
                    else if(piscina.Count > 3){
                        System.Console.WriteLine("Esta jaula está cheia");
                    }
                    else if(alocar != "s"){
                        System.Console.WriteLine("O animal não foi alocado");
                    }
            }
            else if ((typeof(IArboricula)).Equals(@interface)){
                System.Console.WriteLine($":::{classe.Name} pode ir para a Casa na Árvore:::");
                System.Console.Write($"Alocar {classe.Name} na Casa na Árvore? S/N  ");
                alocar = Console.ReadLine().ToLower();
                    if ((alocar == "s") && (casaArvore.Count <= 3)){
                        casaArvore.Add(animal);
                        System.Console.WriteLine("O animal foi alocado");
                    }
                    else if(casaArvore.Count > 3){
                        System.Console.WriteLine("Esta jaula está cheia");
                    }
                    else if(alocar != "s"){
                        System.Console.WriteLine("O animal não foi alocado");
                    }
            }
            else if ((typeof(IBranquiado)).Equals(@interface)){
                System.Console.WriteLine($":::{classe.Name} pode ir para o Aquário:::");
                System.Console.Write($"Alocar {classe.Name} no Aquário? S/N  ");
                alocar = Console.ReadLine().ToLower();
                    if ((alocar == "s") && (aquario.Count <= 3)){
                        aquario.Add(animal);
                        System.Console.WriteLine("O animal foi alocado");
                    }
                    else if(aquario.Count > 3){
                        System.Console.WriteLine("Esta jaula está cheia");
                    }
                    else if(alocar != "s"){
                        System.Console.WriteLine("O animal não foi alocado");
                    }
            }
            else if ((typeof(IQuionofilo)).Equals(@interface)){
                System.Console.WriteLine($":::{classe.Name} pode ir para a Piscina Gelada:::");
                System.Console.Write($"Alocar {classe.Name} na Piscina Gelada? S/N  ");
                alocar = Console.ReadLine().ToLower();
                    if ((alocar == "s") && (aquarioGelados.Count <= 3)){
                        aquarioGelados.Add(animal);
                        System.Console.WriteLine("O animal foi alocado");
                    }
                    else if(aquarioGelados.Count > 3){
                        System.Console.WriteLine("Esta jaula está cheia");
                    }
                    else if(alocar != "s"){
                        System.Console.WriteLine("O animal não foi alocado");
                    }
            }
            else if ((typeof(ITerrestre)).Equals(@interface)){
                System.Console.WriteLine($":::{classe.Name} pode ir para os Pastos ou Caverna de Pedra:::");
                System.Console.Write($"Alocar {classe.Name} na Caverna de Pedra? S/N  ");
                alocar = Console.ReadLine().ToLower();
                    if ((alocar == "s") && (cavernaPedras.Count <= 3)){
                        cavernaPedras.Add(animal);
                        System.Console.WriteLine("O animal foi alocado");
                    }
                    else if(cavernaPedras.Count > 3){
                        System.Console.WriteLine("Esta jaula está cheia");
                    }
                    else if(alocar != "s"){
                        System.Console.WriteLine("O animal não foi alocado");
                    }
            }
            else if ((typeof(IVoador)).Equals(@interface)){
                System.Console.WriteLine($":::{classe.Name} pode ir para a Gaiola:::");
                System.Console.Write($"Alocar {classe.Name} na Gaiola? S/N  ");
                alocar = Console.ReadLine().ToLower();
                    if ((alocar == "s") && (gaiola.Count <= 3)){
                        gaiola.Add(animal);
                        System.Console.WriteLine("O animal foi alocado");
                    }
                    else if(gaiola.Count > 3){
                        System.Console.WriteLine("Esta jaula está cheia");
                    }
                    else if(alocar != "s"){
                        System.Console.WriteLine("O animal não foi alocado");
                    }
            }
            Console.ReadLine();
        }
    }
}
