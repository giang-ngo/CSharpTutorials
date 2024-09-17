using System;
using static System.Net.Mime.MediaTypeNames;

namespace Master_C__Programming.class_and_object_oriented
{
    internal class Lesson2
    {
        Person person = new Person();
        Person person2 = new Person("Nam");
        Person person3 = new Person("Giang", "Ngo");
        Person person4 = new Person("Giang", "Ngo", 23);

        public void DoSomething(Person person)
        {
            Console.WriteLine("First name: " + person.firstName);
            Console.WriteLine("Last name: " + person.lastName);
            Console.WriteLine("Age: " + person.age);
        }
    }

    class Person
    {
        public Person() : this("")
        {

        }

        public Person(string first) : this(first, "")
        {

        }

        public Person(string first, string last) : this(first, last, 0)
        {
        }
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            new Lesson2().DoSomething(this);
        }

        public string firstName;
        public string lastName;
        public int age;

        public void DoSomeThing(Person p)
        {
            //...
        }
    }
}
