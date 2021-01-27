using System;
using ClockReader.models;
using ClockReader.repository;

namespace ClockReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Sau", "20753507018");
            EmployeeRepository employers = new EmployeeRepository("‪C:\\testes\\AFD00009003650016557.txt");

            Console.WriteLine(employers.search(e.Pis).toString());
        }
    }
}
