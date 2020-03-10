using System;
using ByteBank2.Models;

namespace ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente1 = new ContaCorrente(1, 1, "Alexandre");
            ContaCorrente contaCorrente2 = new ContaCorrente(1, 2, "Cesar");

            DepositarConta(contaCorrente1);
            DepositarConta(contaCorrente2);
            SacarConta(contaCorrente1);
            SacarConta(contaCorrente2);

            ContaEspecial contaEspecial1 = new ContaEspecial(1, 2, "Cesar");
            contaEspecial1.SetLimite(1000);
            DepositarConta(contaEspecial1);
            SacarConta(contaEspecial1);
            TransferirEntreContas(contaEspecial1, contaCorrente2);
        }

        public static void DepositarConta(ContaBancaria contaBancaria){
            System.Console.WriteLine("ByteBank - Deposito");
            System.Console.WriteLine("-------------------");
            System.Console.WriteLine();
            string usuario = contaBancaria.Titular;
            System.Console.WriteLine($"Conta: {contaBancaria.GetType()}");
            System.Console.WriteLine($"Bem-vindo - {usuario}");
            System.Console.WriteLine($"Agência: {contaBancaria.Agencia}   Conta: {contaBancaria.NumeroConta}");
            System.Console.WriteLine($"Saldo: {contaBancaria.Saldo}");
            System.Console.Write("Digite o valor do Deposito: ");
            double valor = double.Parse(Console.ReadLine());
            if(contaBancaria.Deposito(valor)){
                System.Console.WriteLine("Deposito Concluido");
                System.Console.WriteLine($"Saldo atual: {contaBancaria.Saldo}");
            }
            else{
                System.Console.WriteLine("Falha ao realizar o depósito.");
            }
        }

        public static void SacarConta(ContaBancaria contaBancaria){
            string usuario = contaBancaria.Titular;
            System.Console.WriteLine("ByteBank - Saque");
            System.Console.WriteLine("-------------------");
            System.Console.WriteLine();
            System.Console.WriteLine($"Conta: {contaBancaria.GetType()}");
            System.Console.WriteLine($"Bem-vindo - {usuario}");
            System.Console.WriteLine($"Agência: {contaBancaria.Agencia}   Conta: {contaBancaria.NumeroConta}");
            System.Console.WriteLine($"Saldo: {contaBancaria.Saldo}");
            System.Console.Write("Digite o valor do Saque: ");
            double valor = double.Parse(Console.ReadLine());
            if(contaBancaria.Saque(valor)){
                System.Console.WriteLine("Saque realizado com sucesso. Retire a nota.");
            }
            else{
                System.Console.WriteLine("Não foi possivel realizar a operação.");
            }
            System.Console.WriteLine($"Saldo atual: {contaBancaria.Saldo}");
            System.Console.WriteLine();
        }

        public static void TransferirEntreContas(ContaBancaria conta1, ContaBancaria conta2){
            string usuario = conta1.Titular;
            Console.WriteLine("ByteBank - Transferencia");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine($"Conta: {conta1.GetType()}");
            Console.WriteLine($"Bem vindo - {usuario}");
            Console.WriteLine($"Agencia: {conta1.Agencia}   Conta: {conta1.NumeroConta}");
            Console.WriteLine($"Saldo origem: {conta1.Saldo}");
            Console.WriteLine($"Saldo destino: {conta2.Saldo}");
            Console.Write("Digite o valor da transferência: ");
            double valor = double.Parse(Console.ReadLine());

            if (conta1.Transferencia(conta2, valor))
            {
                Console.WriteLine("Tranferencia efetuada com sucesso.");
                Console.WriteLine($"Saldo origem: {conta1.Saldo}");
                Console.WriteLine($"Saldo destino: {conta2.Saldo}");
            }
            else
            {
                Console.WriteLine("Operação não pode ser realizada.");
            }
            Console.WriteLine();
        }
    }
}
