namespace HerancaPolimorfismo_Ex1.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuraPerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuraPerHour)
        {
            Name = name;
            Hours = hours;
            ValuraPerHour = valuraPerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuraPerHour;
        }
    }
}
