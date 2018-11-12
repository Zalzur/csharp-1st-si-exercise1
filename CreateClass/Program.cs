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

        public Person(string name, String birthDateString, Genders gender)
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
            Console.WriteLine(person3.ToString());
            Console.ReadKey();
        }   
    }
}
