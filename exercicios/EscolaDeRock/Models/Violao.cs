using System;
using EscolaDeRock.Interfaces;


namespace EscolaDeRock.Models
{
    public class Violao : InstrumentoMusical, IHarmonia, IMelodia, IPercussao
    {
        public bool TocarAcordes(){
            Console.WriteLine("Tocando acordes do Violão.");
            return true;
        }
        public bool TocarSolo(){
            Console.WriteLine("Tocando solo de Violão.");
            return true;
        }

        public bool ManterRitmo(){
            Console.WriteLine("Mantendo o ritmo do Violão.");
            return true;
        } 
    }
}