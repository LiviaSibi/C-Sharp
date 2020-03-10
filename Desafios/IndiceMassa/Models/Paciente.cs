using System;

namespace IndiceMassa
{
    public class Paciente
    {
        public string nome;
        public int peso;
        public double altura;

        public Paciente(string nome, int peso, double altura){
            this.nome = nome;
            this.peso = peso;
            this.altura = altura;
        }
    }
}