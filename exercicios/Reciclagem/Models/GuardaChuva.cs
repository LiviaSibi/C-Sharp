using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GuardaChuva : Lixo, INaoReciclavel
    {
        public string LataCinza(){
            return this.GetType().Name;
        }
    }
}