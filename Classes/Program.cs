using System;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person
            //{
            //    Name = "Manpreet"
            //};

            var person = Person.Parse("Manpreet");

            person.SayHello("John");
        }
    }
}
