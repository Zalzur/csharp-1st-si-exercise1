using System;

namespace CreateClass
{
    class Person
    {
        public enum Genders
        {
            Male,
            Female
        }

        private string name;
        private DateTime birthDate;
        private Genders gender;

        public Person(string name, string birthDateString, Genders gender)
        {
            this.name = name;
            this.birthDate = Convert.ToDateTime(birthDateString); ;
            this.gender = gender;
        }

        public override string ToString()
        {
            return "Name: " + name + "\nBirth year: " + birthDate.Year + "." + birthDate.Month + "." + birthDate.Day + ".\nGender: " + gender;
        }

        static void Main(string[] args)
        {
            Person person1 = new Person("Csaba", "01/08/2008", Genders.Male);
            Person person2 = new Person("Bianka", "05/23/1985", Genders.Female);
            Person person3 = new Person("Ferenc", "11/15/1990", Genders.Male);
            Console.WriteLine(person1.ToString() + "\n");
            Console.WriteLine(person2.ToString() + "\n");
            Console.WriteLine(person3.ToString() + "\n");

            Employee employee1 = new Employee("John", "11/11/1972", Genders.Male, 2000, "Hitman");
            Employee employee2 = new Employee("Elizabeth", "03/05/1986", Genders.Female, 500, "Janitor");
            employee1.Room = new Room(47);
            employee2.Room = new Room(10);
            Console.WriteLine(employee1.ToString() + "\n");
            Console.WriteLine(employee2.ToString() + "\n");
            Employee cloneEmployee = (Employee)employee1.Clone();
            cloneEmployee.Room.roomNumber = 112;
            Console.WriteLine(cloneEmployee.ToString() + "\n");
            Console.ReadKey();
        }   
    }

    class Employee : Person, ICloneable
    {
        private int salary;
        private string profession;
        internal Room Room { get; set; }

        public Employee(string name, string birthDateString, Genders gender, int salary, string profession) : base(name, birthDateString, gender)
        {
            this.salary = salary;
            this.profession = profession;
        }

        public override string ToString()
        {
            return base.ToString() + "\nSalary: " + salary + "\nProfession: " + profession + "\nRoom number: " + Room.roomNumber;
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.roomNumber);
            return newEmployee;
        }
    }

    class Room
    {
        public int roomNumber;

        public Room(int roomNumber)
        {
            this.roomNumber = roomNumber;
        }
    }
}
