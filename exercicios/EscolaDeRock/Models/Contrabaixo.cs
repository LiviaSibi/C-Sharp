using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Contrabaixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo(){
            Console.WriteLine("Mantendo o ritmo do Contrabaixo.");
            return true;
        }

        public bool TocarAcordes(){
            Console.WriteLine("Tocando acordes de Contrabaixo.");
            return true;
        }
    }
}