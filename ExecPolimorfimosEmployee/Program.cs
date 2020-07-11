using System;
using ExecPolimorfimosEmployee.Entities;
using System.Collections.Generic;
using System.Globalization;
namespace ExecPolimorfimosEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> listEmployee = new List<Employee>();
            
            for (int i = 1; i<=n; i++) {

                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)?");
                string outsorced = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if(outsorced == "y") {
                    Console.Write("Additional charge: ");
                    double aditionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listEmployee.Add(new OutsourcedEmployee(name,hours,valuePerHour,aditionalCharge));
                }
                else
                {
                    listEmployee.Add(new Employee(name, hours, valuePerHour));
                }

            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee employee in listEmployee)
            {

                Console.WriteLine(employee.Name + " - $" + employee.Payament().ToString("F2",CultureInfo.InvariantCulture));
                
            }

        }
    }
}
