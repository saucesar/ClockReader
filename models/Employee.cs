namespace ClockReader.models
{
    public class Employee
    {
        string name;
        string pis;

        public Employee(string name, string pis){
            this.name = name;
            this.pis = pis;
        }

        public string Name { get => name; set => name = value; }
        public string Pis { get => pis; set => pis = value; }

        public string toString() {
            return this.name + " " + this.pis;
        }
    }
}