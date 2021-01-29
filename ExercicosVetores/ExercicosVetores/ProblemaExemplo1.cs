using System;
using System.Globalization;

namespace ExercicosVetores
{
    public class ProblemaExemplo1
    {
        public static void Exemplo1()
        {
            int quantity = int.Parse(Console.ReadLine(), 
                CultureInfo.InvariantCulture);

            var vect = CreateVector(quantity);

            var average = AverageVector(vect);

            Console.WriteLine("AVERAGE HEIGT = " + average.ToString
                ("F2", CultureInfo.InvariantCulture));
        }

        public static double[] CreateVector(int quantity)
        {
            double[] vect = new double[quantity];

            for (int i = 0; i < quantity; i++)
            {
                double putHeigh = double.Parse(Console.ReadLine(),
                    CultureInfo.InvariantCulture);

                vect[i] = putHeigh;
            }

            return vect;
        }

        public static double AverageVector(double[] vector)
        {
            double totalHeighs = 0;
            for(int i = 0; i < vector.Length; i++)
            {
                totalHeighs += vector[i];
            }

            double average = totalHeighs / vector.Length;

            return average;
        }
    }
}