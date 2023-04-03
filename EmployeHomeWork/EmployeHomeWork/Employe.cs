namespace EmployeHomeWork
{
    public class Employe
    {
        private static int _counter = 0;
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string SurName { get; private set; }
        public string SecondName { get; private set; }
        public string Department { get; internal set; }
        public decimal Salary { get; internal set; }

        public Employe(string name, string surName, string secondName,
            string department, decimal salary)
        {
            Id = ++_counter;
            Name = name;
            SurName = surName;
            SecondName = secondName;
            Department = department;
            Salary = salary;
        }

        public string FullName => $"{SurName} {Name} {SecondName}";

        public override string ToString()
        {
            return $"{Id}\t{FullName} - {Department} - {Salary} руб.";
        }
    }
}
