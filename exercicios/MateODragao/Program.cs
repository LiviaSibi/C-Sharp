using System;
using MateODragao.Models;

namespace MateODragao {
    class Program {
        static void Main (string[] args){

            bool jogadorNaoDesistiu = true;

            do {
                //* INICIO - Menu Principal */
                Console.Clear();
                System.Console.WriteLine ("******************************");
                System.Console.WriteLine ("        Mate o Dragão!");
                System.Console.WriteLine ("******************************");

                System.Console.WriteLine (" 1 - Iniciar jogo");
                System.Console.WriteLine (" 0 - Sair do jogo");
                System.Console.Write ("Digite o código da opção: ");

                string opcaoJogador = Console.ReadLine ();
                //* FIM - Menu Principal */

                switch (opcaoJogador) {
                    case "1":
                        Console.Clear();

                        //* INICIO - Criando os personagens (objetos) */
                        Guerreira guerreiro = CriarGuerreiro();

                        Dragao dragao = CriarDragao();
                        //* FIM - Criando os personagens (objetos) */

                        //*  INÍCIO - Primeiro Diálogo  *//
                        CriarDialogo(guerreiro.Nome, $"{dragao.Nome}, seu louco! Vim-lhe derrotar-lhe-ei!");
                        CriarDialogo(dragao.Nome, "Kkkk! Humana tolinha. Quem pensa que és?");
                        FinalizarDialogo();
                        //*   FIM - Primeiro Diálogo   *//

                        //*  INÍCIO - Segundo Diálogo  *//
                        CriarDialogo(guerreiro.Nome, $"Eu sou {guerreiro.Nome}! Da casa {guerreiro.Sobrenome}, ó criatura morfética!");
                        CriarDialogo(guerreiro.Nome, $"Vim de {guerreiro.CidadeNatal} para derrotar-lhe e mostrar meu valor!");
                        CriarDialogo(dragao.Nome, "WHO? Bom, que seja... fritar-te-ei e devorar-te-ei, primata insolenete!");
                        FinalizarDialogo();
                        //*   FIM - Segundo Diálogo   *//

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;
                        bool jogadorNaoCorreu = true;

                        //* INÍCIO - da TRETA *//                      
                        if(jogadorAtacaPrimeiro) {
                            System.Console.WriteLine("------------------------------");
                            System.Console.WriteLine("      Turno do Jogador");
                            System.Console.WriteLine("------------------------------");
                            System.Console.WriteLine("Escolha sua ação: ");
                            System.Console.WriteLine(" 1 - Atacar com a Espada");
                            System.Console.WriteLine(" 2 - Fugir");
                            System.Console.Write (" Digite o código da opção:");
                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch(opcaoBatalhaJogador){
                                case "1":
                                    Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);

                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;
                                    int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                                    if(guerreiroDestrezaTotal > dragaoDestrezaTotal){
                                        System.Console.WriteLine();
                                        CriarDialogo(guerreiro.Nome, "Toma essa lagarto MALDIITOO!");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreira: {guerreiro.Vida}");
                                    }

                                    else {
                                        System.Console.WriteLine();
                                        CriarDialogo(dragao.Nome, "Errrrrou, humanóide tosco!");
                                        System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine ($"HP Jogador: {guerreiro.Vida}");
                                    }
                                break;

                                case "2":
                                    System.Console.WriteLine();
                                    jogadorNaoCorreu = false;
                                    CriarDialogo(guerreiro.Nome, "FLW VLW!");
                                    CriarDialogo(dragao.Nome, "GG EZ!");
                                break;
                            }

                            FinalizarDialogo();
                        }
                        //*   FIM - da Treta   */

                        //* INICIO - Turnos Oficiais */
                        while(dragao.Vida > 0 && guerreiro.Vida > 0 && jogadorNaoCorreu) {
                            System.Console.WriteLine ("------------------------------");
                            System.Console.WriteLine("       Turno do Dragão ");
                            System.Console.WriteLine ("------------------------------");
                            Random geradorNumeroAleatorio = new Random();
                                int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);

                                int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                            if (dragaoDestrezaTotal > guerreiroDestrezaTotal){
                                System.Console.WriteLine();
                                CriarDialogo(dragao.Nome, "Tá pegando fogo bicho!");
                                guerreiro.Vida -= dragao.Forca;
                                System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                System.Console.WriteLine($"HP Guerreira: {guerreiro.Vida}");
                            }

                            else {
                                System.Console.WriteLine();
                                CriarDialogo(guerreiro.Nome, "Vem tranquilo, não se afoba não!");
                                System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                System.Console.WriteLine ($"HP Jogador: {guerreiro.Vida}");
                            }

                            FinalizarDialogo();

                            if (guerreiro.Vida <= 0) {
                                System.Console.WriteLine("GAME OVER!");
                                System.Console.WriteLine ("Jogador Murreeeeeu!");
                                FinalizarDialogo();
                                break;
                            }
                            
                            System.Console.WriteLine ("------------------------------");
                            System.Console.WriteLine("      Turno do Jogador");
                            System.Console.WriteLine ("------------------------------");
                            System.Console.WriteLine("Escolha sua ação: ");
                            System.Console.WriteLine(" 1 - Atacar com a Espada");
                            System.Console.WriteLine(" 2 - Fugir");
                            System.Console.Write (" Digite o código da opção:");
                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch(opcaoBatalhaJogador){
                                case "1":
                                    geradorNumeroAleatorio = new Random();
                                    numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);

                                    guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;
                                    int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                                    if(guerreiroDestrezaTotal > dragaoDestrezaTotal){
                                        System.Console.WriteLine();
                                        CriarDialogo(guerreiro.Nome, "Toma essa lagarto MALDIITOO!");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Guerreira: {guerreiro.Vida}");
                                    }

                                    else {
                                        System.Console.WriteLine();
                                        CriarDialogo(dragao.Nome, "Errrrou, humanóde tosca!");
                                    }
                                    break;

                                case "2":
                                    System.Console.WriteLine();
                                    jogadorNaoCorreu = false;
                                    CriarDialogo(guerreiro.Nome, "FLW VLW!");
                                    CriarDialogo(dragao.Nome, "GG EZ!");
                                break;
                            }

                            if(dragao.Vida <= 0) {
                                System.Console.WriteLine("O dragão morreu");
                                System.Console.WriteLine("Você venceu a batalha!");
                                FinalizarDialogo();
                                break;
                            }

                            FinalizarDialogo();
                        }                            

                        //*  FIM - Turno Jogador  *//

                        break;

                    case "0":
                        jogadorNaoDesistiu = false;
                        break;

                    default:
                        System.Console.WriteLine ("Comando desconhecido");
                        break;
                }
            } while (jogadorNaoDesistiu);
        }

        private static void CriarDialogo(string nome, string frase){
            System.Console.WriteLine($"{nome.ToUpper()}: {frase}");
        }

        private static void FinalizarDialogo(){
            System.Console.WriteLine();
            System.Console.WriteLine("Aperte ENTER para prosseguir");
            Console.ReadLine();
            Console.Clear();
        }

        private static Guerreira CriarGuerreiro(){
            Guerreira guerreiro = new Guerreira();
            guerreiro.Nome = "Joana";
            guerreiro.Sobrenome = "d'Arc II";
            guerreiro.CidadeNatal = "Domrémy";
            guerreiro.DataNascimento = DateTime.Parse("03/11/1520");
            guerreiro.FerramentaAtaque = "Espada e Adaga";
            guerreiro.FerramentaProtecao = "Armadura de ferro";
            guerreiro.Forca = 3;
            guerreiro.Destreza = 3;
            guerreiro.Inteligencia = 2;
            guerreiro.Vida = 20;

            return guerreiro;
        }

        private static Dragao CriarDragao(){
            Dragao dragao = new Dragao();
            dragao.Nome = "Dragonildo";
            dragao.Forca = 5;
            dragao.Destreza = 1;
            dragao.Inteligencia = 3;
            dragao.Vida = 300;

            return dragao;
        }
    }
}