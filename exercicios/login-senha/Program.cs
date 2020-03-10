using System;

namespace login_senha
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string senha;

            Console.Write("Login: ");
            login=Console.ReadLine();
            Console.Write("Senha: ");
            senha=Console.ReadLine();

            if ((login == "admin") && (senha == "admin")){
                Console.WriteLine("Bem-vindo Administrador");
            }

            else {
                Console.WriteLine("Bem-vindo Usuário");
            }
        }
    }
}
