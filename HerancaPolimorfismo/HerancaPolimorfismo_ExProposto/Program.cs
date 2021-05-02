using HerancaPolimorfismo_ExProposto.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace HerancaPolimorfismo_ExProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                char pType = ' ';
                while(pType != 'c' && pType != 'u' && pType != 'i')
                {
                    Console.Write("Common, used or imported (c/u/i)? ");
                    pType = char.Parse(Console.ReadLine());
                }

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),
                    CultureInfo.InvariantCulture);

                switch (pType)
                {
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, date));
                        break;

                    case 'i':
                        Console.Write("Customs fee: ");
                        double customFee = double.Parse(Console.ReadLine(), 
                            CultureInfo.InvariantCulture);
                        products.Add(new ImportedProduct(name, price, customFee));
                        break;

                    default:
                        products.Add(new Product(name, price));
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(var product in products)
                Console.WriteLine(product.PriceTag());
        }
    }
}
