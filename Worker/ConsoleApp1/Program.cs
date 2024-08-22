using System;
using System.Globalization;
using ConsoleApp1.Entities;
using ConsoleApp1.Entities.Enums;


namespace Couse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);//instancia o departamento 
            Worker worker = new Worker(name, level, baseSalary, dept);// Instancia as informações do funcionario e vincula o departamento 

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)//Entrada dos contratos
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (Hour): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);//instancia os contratos 
                worker.addContract(contract);//Vincula os contratos ao funcionario 
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");

            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: "+ worker.Name);
            Console.WriteLine("Department: "+ worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2",CultureInfo.InvariantCulture));



        }
    }
}



/*
    OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
Se mesmo assim ainda tiver dando erro, há ainda uma terceira forma:

OrderStatus os;
Enum.TryParse("Delivered", out os);
*/