using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Papelao : Lixo, IPapel
    {
        public string LataAzul(){
            return this.GetType().Name;
        }
    }
}