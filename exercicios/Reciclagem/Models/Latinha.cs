using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Latinha : Lixo, IMetal
    {
        public string LataAmarela(){
            return this.GetType().Name;
        }
    }
}