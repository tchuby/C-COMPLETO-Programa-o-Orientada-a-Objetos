using System;
using System.Globalization;

namespace ExMembrosEstaticos_ConversorDeMoeda
{
    class Program : Conversor
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comparar? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var reais = Converter(cotacao, qtd);
            Console.WriteLine($"Valor a ser pago em reais = {reais.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
