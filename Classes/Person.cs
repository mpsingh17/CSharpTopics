using System;

namespace Classes
{
    public class Person
    {
        public string Name;

        public void SayHello(string to)
        {
            Console.WriteLine("Hello {0}, I am {1}", to, Name);
        }

        public static Person Parse(string name)
        {
            var person = new Person
            {
                Name = name
            };

            return person;
        }
    }
}
