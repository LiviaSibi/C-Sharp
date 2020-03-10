using System;

namespace ByteBank
{
    public class Cliente
    {
        private string _nome;
        private string _email;
        private string _cpf;
        private string _senha;

        public string Nome{
            get {return _nome;}
            set{_nome = value;}
        }

        public string Email{
            get {return _email;}
            set{_email = value;}
        }

        public string Cpf{
            get {return _cpf;}
            set{_cpf = value;}
        }

        public string Senha{
            get{return _senha;}
        }

        public Cliente(string nome, string email, string cpf){
            this._nome = nome;
            this._email = email;
            this._cpf = cpf;
        }
        
        public bool TrocarSenha (string senha){
            if ((senha.Length > 6) && (senha.Length < 16)) {
                this._senha = senha;
                return true;
            }
            else{
                return false;
            }
        }
    }
}