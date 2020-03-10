using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Tambores : InstrumentoMusical, IPercussao
    {
        public bool ManterRitmo(){
            Console.WriteLine("Mantendo o ritmo dos Tambores.");
            return true;
        }
    }
}