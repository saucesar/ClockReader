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

        public Employee(string fileLine)
        {
            this.pis = fileLine.Substring(25, 34);
            this.name = fileLine.Substring(35);
        }

        public string Name { get => name; set => name = value; }
        public string Pis { get => pis; set => pis = value; }

        public string toString() {
            return this.name + " " + this.pis;
        }
    }
}