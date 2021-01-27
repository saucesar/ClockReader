using System.Collections;
using System.IO;
using ClockReader.models;

namespace ClockReader.repository
{
    public class EmployeeRepository
    {
        ArrayList employers;
        string filePath;

        public EmployeeRepository(string path)
        {
            this.employers = new ArrayList();
            this.filePath = path;
            this.readFile();
        }

        public void readFile()
        {
            StreamReader reader = new StreamReader(this.filePath);
            string line = reader.ReadLine();
            while (line != null)
            {
                this.Add(new Employee(line));
                line = reader.ReadLine();
            }
        }

        public void Add(Employee e)
        {
            this.employers.Add(e);
        }

        public Employee search(string pis)
        {
            Employee employee = null;

            foreach(Employee e in this.employers)
            {
                if(e.Pis.Equals(pis))
                {
                    employee = e;
                    break;
                }
            }

            return employee;
        }
    }
}