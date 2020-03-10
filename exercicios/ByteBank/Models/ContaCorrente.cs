using System;
namespace ByteBank.Models
{
    public class ContaCorrente
    {
        public Cliente Titular {get; set;}
        public int Agencia {get; set;}
        public int NumeroConta {get; set;}
        private double _saldo;

        public double Saldo{
            get {return _saldo;}
        }

        public ContaCorrente (int agencia, int numeroConta, Cliente titular){
            this.Agencia = agencia;
            this.NumeroConta = numeroConta;
            this.Titular = titular;
            this._saldo = 0.0;
        }

        public double Deposito (double valor){
            if(valor > 0){
                this._saldo += valor;
                return this._saldo;
            }
            else{
                return this._saldo;
            }
        }
        public bool Saque (double valor){
            if(valor > 0){
                if (valor <= this._saldo) {
                    this._saldo -= valor;
                    return true;
                }
                else{
                    return false;
                }
            }
            else{
                return false;
            }
        }
        public bool Transferencia (ContaCorrente destino, double valor){
            if (this.Saque (valor)) {
                destino.Deposito(valor);
                return true;
            }
            else {
                return false;
            }
        }
    }
}