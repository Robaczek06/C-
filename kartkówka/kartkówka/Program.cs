using System;

namespace kartkówka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Anna", "Kowal", 3, 1500);
            Employee employee2 = new Employee("Krzysztof", "Róża", 6, 1000);
            employee2.show();
            employee2.LastName = employee.LastName;
            employee.show();
            employee2.show();
            employee.Name = "Aleksandra";
            employee.Salary = 20000;
            employee.Intership = 11;
            employee.show();
        }

    }
    class Employee
    {
        private string name;
        private string lastname;
        private float intership;
        private float salary;

        public Employee() { }
        public Employee(string name, string lastname, float intership, float salary)
        {
            this.name = name;
            this.lastname = lastname;
            if (intership > 0 && salary > 0)
            {
                this.intership = intership;
                this.salary = salary;
            }
            else
            {
                this.intership = 0;
                this.salary = 0;
            }
        }
        public void show()
        {
            Console.WriteLine($"imie:{name}  nazwisko:{lastname}  staż pracy:{intership}  pensja:{salary}  dodatek stażowy: {add_sal()}");
            Console.WriteLine();
        }
        public double add_sal()
        {
            double percent, val;
            if (intership < 5) percent = 0;
            else if (intership >= 5 && intership <= 10) percent = 0.05;
            else percent = 0.10;
            val = salary * percent;
            return val;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public float Salary
        {
            set { salary = value; }
            get { return salary; }
        }
        public float Intership
        {
            set { intership = value; }
            get { return intership; }
        }

    }
}
