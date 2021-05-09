using HerancaPolimorfismo_ExProp2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace HerancaPolimorfismo_ExProp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> payers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int nPayers = int.Parse(Console.ReadLine());
            for(int i = 1; i <= nPayers; i++)
            {
                Console.Write($"Tax payer #{i} data:");
                Console.Write("Individual or Company (i/c)? ");
                char payerType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), 
                    CultureInfo.InvariantCulture);
                if(payerType == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(),
                        CultureInfo.InvariantCulture);

                    var payer = new Individual(name, 
                                               anualIncome, healthExpenditures);
                    payers.Add(payer);
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());

                    var payer = new Company(name, anualIncome, numberEmployees);
                    payers.Add(payer);
                }
            }

            double totalTaxes = 0;

            Console.WriteLine("TAXES PAID:");
            foreach (var payer in payers)
            {
                Console.WriteLine(payer);
                totalTaxes += payer.Tax();
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: " + 
                totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
