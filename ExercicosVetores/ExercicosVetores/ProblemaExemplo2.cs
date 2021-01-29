using System;
using System.Globalization;

namespace ExercicosVetores
{
    public class ProblemaExemplo2
    {
        public static void Exemplo2()
        {
            int quantity = int.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            var produtos = CreateVector(quantity);

            Console.Write("AVERAGE PRICE = " + AveragePrice(produtos));
        }

        public static Product[] CreateVector(int quantity)
        {
            Product[] produtos = new Product[quantity];

            for(int i =0; i < quantity; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), 
                    CultureInfo.InvariantCulture);

                var produto = new Product(nome, preco);

                produtos[i] = produto;
            }

            return produtos;
        }

        public static string AveragePrice(Product[] produtos)
        {
            double sumPrice = 0;
            foreach (var produto in produtos)
            {
                sumPrice += produto.Preco;
            }

            var average = sumPrice / produtos.Length;

            return average.ToString("F2",
                CultureInfo.InvariantCulture);
        }
    }

    public class Product
    {
        public string NomeProduto { get; set; }
        public double Preco { get; set; }

        public Product(string nomeProduto, double preco)
        {
            NomeProduto = nomeProduto;
            Preco = preco;
        }
    }  
}