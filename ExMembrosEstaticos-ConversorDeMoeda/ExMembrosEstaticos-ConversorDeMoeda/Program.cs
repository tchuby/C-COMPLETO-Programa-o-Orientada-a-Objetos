using System;
using System.Globalization;

namespace ExMembrosEstaticos_ConversorDeMoeda
{
    static class Program
    {
        static void Main(string[] args)
        {
            Converte();
        }

        static void Converte()
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comparar? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var reais = Conversor.Converter(cotacao, qtd);
            Console.WriteLine($"Valor a ser pago em reais = {reais.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
