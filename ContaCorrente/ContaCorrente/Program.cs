using System;
using System.Globalization;

namespace ContaCorrente
{
    class Program
    {
        private static NumberStyles cultureInfo;

        static void Main(string[] args)
        {
            Operar();
            Console.ReadKey();
        }
        
        static void Operar()
        {
            string numeroConta = "Entre o número da conta:";
            string entrarNome = "Entre o titular da conta:";
            string condicaoDepositoInicial = "Havera depósito inicial (s/n)?";
            string entrarDepositoInicial = "Entre o valor de depósito inicial:";

            Console.Write(numeroConta);
            int nConta = int.Parse(Console.ReadLine());

            Console.Write(entrarNome);
            string nomeTitular = Console.ReadLine();

            Console.Write(condicaoDepositoInicial);
            string condDepositoInicial = Console.ReadLine();

            if (condDepositoInicial == "s")
            {
                Console.Write(entrarDepositoInicial);
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }                
        }
    }
}
