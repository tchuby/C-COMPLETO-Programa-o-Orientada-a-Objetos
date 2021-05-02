using HerancaPolimorfismo_Ex1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace HerancaPolimorfismo_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data");

                char outsourced = ' ';
                while (outsourced != 'y' && outsourced != 'n')
                {
                    Console.Write("Outsourced (y/n)? ");
                    outsourced = char.Parse(Console.ReadLine());
                }
                
                Console.Write("Name: ");
                string name = Console.ReadLine();
                
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), 
                                                    CultureInfo.InvariantCulture);
                
                if(outsourced == 'n')
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
                else
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse
                        (Console.ReadLine(),CultureInfo.InvariantCulture);

                    employees.Add(new OutsourceEmployee
                        (name, hours, valuePerHour, additionalCharge));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach(var employee in employees)
            {
                Console.WriteLine($"{employee.Name} - $ " +
                    $"{employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
