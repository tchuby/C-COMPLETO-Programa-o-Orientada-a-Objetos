using System;
using System.Collections.Generic;
using System.Globalization;

namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Entrada();
        }

        public static void Entrada()
        {
            string continuar = "s";
            while (continuar != "n")
            { 
                Console.WriteLine("Quantidade de triângulos a comparar suas áreas:");
                int nTri = int.Parse(Console.ReadLine());
                var triangulos = Triangulos(nTri);
                var resposta = CompararAreas(triangulos);
                Console.WriteLine(resposta);
                Console.WriteLine("Continuar comparando? s ou n.");
                continuar = Console.ReadLine();
                Console.Clear();
            }
        }

        public static List<Triangulo> Triangulos(int nTri)
        {
            var triangulos = new List<Triangulo>();

            for (int i = 1; i <= nTri; i++)
            {
                triangulos.Add(EntradaDeLados(i.ToString()));
            }

            return triangulos;
        }

        public static Triangulo EntradaDeLados(string nome)
        {
            nome = $"triângulo número {nome}";
            Console.WriteLine($"Entre com as medidas dos lados do {nome}");
            double ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var area = CalcularArea(ladoA, ladoB, ladoC);
            var triangulo = Criar(ladoA, ladoB, ladoC, area, nome);

            return triangulo;
        }

        public static Triangulo Criar(double a, double b, double c, double s, string nome)
        {
            Triangulo triangulo = new Triangulo()
            {
                A = a,
                B = b,
                C = c,
                Area = s, 
                Nome = nome
            };

            return triangulo;
        }

        public static double CalcularArea(double a, double b, double c)
        {
            var perimetro = (a + b + c) / 2;
            var areaTri = Math.Sqrt(perimetro * (a * b * c));

            return areaTri;
        }

        public static string CompararAreas(List<Triangulo> triangulos) 
        {
            string maior = "nenhum";
            double areaAnterior = 0;

            foreach (var triangulo in triangulos) 
            {
                if(triangulo.Area >= areaAnterior)
                {
                    maior = triangulo.Nome;
                    areaAnterior = triangulo.Area;
                }
                Console.WriteLine($"Área do {triangulo.Nome} = {triangulo.Area.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            string resposta = $"O triângulo de maior área é o {maior}";
            return resposta;
        }
    }
}
