using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Garrafa : Lixo, IVidro
    {
        public string LataVerde(){
            return this.GetType().Name;
        }
    }
}