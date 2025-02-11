using System;

namespace klasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jan", "kowalski", 35);
            person.showPerson();
            Person person1 = new Person(person);
            person1.showPerson();
            Person person2 = new Person();
            person2.setName("beata");
            person2.lastname = "tak";
            person2.Age = 100;
            person2.showPerson();

            //konstruktor Age ma problemy mózgowe bo 3 sposób uważa to za jakiś parametr czy coś
        }
    }
    class Person
    {
        private string name;
        private string surname;
        private int age;

        public Person() { }

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.age = age;
            this.surname = surname;
        }
        public Person(Person p) //konstruktor kopiujący
        {
            name = p.name;
            surname = p.surname;
            age = p.age;

        }
        public void showPerson()
        {
            Console.WriteLine($"Imię: {name}   Nazwisko: {surname}   wiek: {age}");
        }

        public string getName() { return name; }
        public void setName(string name) { this.name = name; }
        public string lastname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Age { get; set; }
    }
}
