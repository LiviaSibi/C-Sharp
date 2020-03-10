using System;
using ByteBank.Models;
namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //*******Cadastro Cliente*******/
            Console.Clear();
            System.Console.WriteLine("Cadastro de Cliente");
            System.Console.WriteLine();
            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("E-mail: ");
            string email= Console.ReadLine();
            System.Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            
            Cliente cliente1 = new Cliente(nome, email, cpf);

            bool trocouSenha = false;
            
            do{
                System.Console.Write("Digite a Senha: ");
                string senha = Console.ReadLine();
                trocouSenha = cliente1.TrocarSenha (senha);

                if (!trocouSenha){
                    System.Console.WriteLine("Senha não atende aos requisitos");
                }
                else{
                    System.Console.WriteLine("Senha trocada com sucesso");
                }
            }while(!trocouSenha);

            //*******Cadastro Conta Corrente*******/
            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("    Casdastro de Conta Corrente");
            System.Console.WriteLine();
            System.Console.Write("Agência: ");
            int agencia = int.Parse(Console.ReadLine());
            System.Console.Write("Número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            bool saldoValido = false;
            double saldo;

            do{
                System.Console.Write("Digite seu saldo: ");
                saldo = double.Parse(Console.ReadLine());

                if (saldo >= 0){
                    saldoValido = true;
                    System.Console.WriteLine("Sua conta foi criada com sucesso!");
                }
                else{
                    System.Console.WriteLine("O saldo não pode ser negativo");
                }
            }while(!saldoValido);

            ContaCorrente contaCorrente = new ContaCorrente (agencia, numeroConta, cliente1);
            contaCorrente.Deposito(saldo);

            //*******Menu Conta Corrente*******/
            string opcaoConta;
            do{
                Console.Clear();
                Cliente usuario = contaCorrente.Titular;
                System.Console.WriteLine($"ByteBank - Bem-vindo {usuario.Nome}");
                System.Console.WriteLine(" 1 - Depositar");
                System.Console.WriteLine(" 2 - Sacar");
                System.Console.WriteLine(" 3 - Tranferência");
                System.Console.WriteLine(" 0 - Sair");
                System.Console.Write ("Digite o código da opção: ");
                opcaoConta = Console.ReadLine();
                
                
                switch (opcaoConta) {
                    case "1":
                    Console.Clear();
                    System.Console.WriteLine("ByteBank - Deposito");
                    System.Console.WriteLine($"Agência: {contaCorrente.Agencia}   Conta: {contaCorrente.NumeroConta}");
                    System.Console.WriteLine($"Saldo: {contaCorrente.Saldo}");
                    System.Console.WriteLine();
                    System.Console.Write("Digite o valor a ser depositado: ");
                    double valor = double.Parse(Console.ReadLine());
                    saldo = contaCorrente.Deposito(valor);
                    System.Console.WriteLine();
                    System.Console.WriteLine($"Seu novo saldo é de: {contaCorrente.Saldo}");
                    System.Console.WriteLine("Aperte ENTER para prosseguir");
                    Console.ReadLine();
                    break;

                    case "2":
                    Console.Clear();
                    System.Console.WriteLine("ByteBank - Saque");
                    System.Console.WriteLine($"Agência: {contaCorrente.Agencia}     Conta: {contaCorrente.NumeroConta}");
                    System.Console.WriteLine($"Saldo: {contaCorrente.Saldo}");
                    System.Console.WriteLine();
                    System.Console.Write("Digite o valor a ser sacado: ");
                    valor = double.Parse(Console.ReadLine());
                    
                    if(contaCorrente.Saque(valor)){
                        System.Console.WriteLine();
                        System.Console.WriteLine("Saque feito com sucesso. Retire a nota");
                        System.Console.WriteLine($"Seu novo saldo é de: {contaCorrente.Saldo}");
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();
                    }
                    else{
                        System.Console.WriteLine("Não foi possível realizar a operação");
                        
                    }
                    break;

                    case "3":
                    Console.Clear();
                    System.Console.WriteLine("ByteBank - Tranferência");
                    System.Console.WriteLine($"Agência: {contaCorrente.Agencia}     Conta: {contaCorrente.NumeroConta}");
                    System.Console.WriteLine($"Saldo: {contaCorrente.Saldo}");
                    System.Console.WriteLine();
                    System.Console.Write("Digite o valor a ser trânsferido: ");
                    valor = double.Parse(Console.ReadLine());
                    Cliente cliente2 = new Cliente ("Alexandre", "123.321.456.56", "ale@email.com");
                    ContaCorrente contaCorrente2 = new ContaCorrente(123, 132, cliente2);

                    if(contaCorrente.Transferencia(contaCorrente2, valor)){
                        System.Console.WriteLine("Tranferência efetuada com sucesso");
                        System.Console.WriteLine($"Seu novo saldo é de: {contaCorrente.Saldo}");
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();
                    }
                    else{
                        System.Console.WriteLine("Operação não pode ser realizada");
                    }
                    break;
                }
            }while(opcaoConta!="0");
            
        }
    }
}
