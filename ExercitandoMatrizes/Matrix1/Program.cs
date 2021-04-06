using System;

namespace Matrix1
{
    class Program
    {
        static void Main(string[] args)
        {
            OnStart();
        }

        public static void OnStart()
        {
            var matrix = InputMatrix();
            PrintMainDaigonal(matrix);
            PrintCountNegativeValues(matrix);
        }

        public static int[,] InputMatrix()
        {
            int matrixOrder = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixOrder, matrixOrder];

            for(int i = 0; i < matrixOrder; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < matrixOrder; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            return matrix;
        }

        public static void PrintMainDaigonal(int[,] matrix)
        {
            Console.WriteLine("Main diagonal:");
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write(matrix[i, i] + " ");
            }
            Console.WriteLine();
        }

        public static void PrintCountNegativeValues(int[,] matrix)
        {
            int count = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                        count++;
                }
            }
            Console.WriteLine($"Negative numbers = {count}");
        }
    }
}
