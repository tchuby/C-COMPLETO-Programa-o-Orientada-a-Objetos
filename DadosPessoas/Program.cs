using System;

namespace CompareAges
{
    class Program
    {
        static void Main(string[] args)
        {
            Input();
            Console.ReadKey();
        }

        public static void Input()
        {
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome:");
            string name1 = Console.ReadLine();
            Console.Write("Idade:");
            int age1 = int.Parse(Console.ReadLine());

            var firstPerson = new Person()
            {
                Name = name1,
                Age = age1
            };

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome:");
            string name2 = Console.ReadLine();
            Console.Write("Idade:");
            int age2 = int.Parse(Console.ReadLine());

            var secondPerson = new Person()
            { 
                Name = name2,
                Age = age2
            };

            var outPut = OldestPersonIs(firstPerson, secondPerson);

            Console.WriteLine("A pessoa mais velha: {0}", outPut);
        }

        public static string OldestPersonIs(Person firstPerson, Person secondPerson)
        {
            string olderPerson;
            if (firstPerson.Age > secondPerson.Age)
                olderPerson = firstPerson.Name;
            else if (firstPerson.Age < secondPerson.Age)
                olderPerson = secondPerson.Name;
            else olderPerson = "Ambas as pessoas tem a mesma idade.";

            return olderPerson;
        }
    }
}
