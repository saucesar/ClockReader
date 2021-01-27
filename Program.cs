using System;
using ClockReader.models;

namespace ClockReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Sau", "11111111111");
            Console.WriteLine(e.toString());
        }
    }
}
