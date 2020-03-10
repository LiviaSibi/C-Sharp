namespace AgendaTelefonica
{
    public class Registro
    {
        private string _nome;
        private string _telefone;
        private string _aniversario;

        public string Nome{
            get {return _nome;}
            set{_nome = value;}
        }

        public string Telefone{
            get {return _telefone;}
            set {_telefone = value;}
        }

        public string Aniversario{
            get {return _aniversario;}
            set {_aniversario = value;}
        }

        public Registro(string nome, string telefone, string aniversario){
            this._nome = nome;
            this._telefone = telefone;
            this._aniversario = aniversario;
        }
    }
}