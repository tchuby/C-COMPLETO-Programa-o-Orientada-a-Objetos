using System;
using System.Globalization;

namespace ContaCorrente
{
    static class Program
    {
        static void Main(string[] args)
        {
            Operar();
        }

        static void Operar()
        {
            string numeroConta = "Entre o número da conta: ";
            string entrarNome = "Entre o titular da conta: ";
            string condicaoDepositoInicial = "Haverá depósito inicial (s/n)? ";
            string entrarDepositoInicial = "Entre o valor do depósito inicial: ";

            Console.Write(numeroConta);
            int nConta = int.Parse(Console.ReadLine());

            Console.Write(entrarNome);
            string nomeTitular = Console.ReadLine();

            Conta conta = new Conta( nConta, nomeTitular);

            Console.Write(condicaoDepositoInicial);
            char condDepositoInicial = char.Parse(Console.ReadLine());

            if (condDepositoInicial == 's')
            {
                Console.Write(entrarDepositoInicial);
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Depositar(depositoInicial);
                Console.WriteLine();
            }

            Console.WriteLine("Dados da conta: ");
            Atualizar(conta);

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Atualizar(conta);

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Atualizar(conta);          
        }

        public static void Atualizar(Conta conta)
        {
            Console.WriteLine(conta);
            Console.WriteLine();
        }
    }
}