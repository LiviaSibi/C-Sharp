using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GarrafaPET : Lixo, IPlastico
    {
        public string LataVermelha(){
            return this.GetType().Name;
        }
    }
}