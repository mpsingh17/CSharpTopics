using System;

namespace Enumeration
{
    public enum DaysInWeek : short
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }

    class Program
    {
        static void Main(string[] args)
        {
            DaysInWeek day = DaysInWeek.Monday;
            Console.WriteLine("Day of week: {0}", day); // Returns: Monday

            int dayValue = (int)day;
            Console.WriteLine("Day of week Value: {0}", dayValue); // Returns: 1

            day = (DaysInWeek)dayValue;
            Console.WriteLine("Day of week: {0}", day); // Returns: Monday
            
            Console.WriteLine("Day of week: {0}", Enum.GetName(typeof(DaysInWeek), dayValue)); // Returns: Monday if found. Else return null.

            DaysInWeek notInEnum = (DaysInWeek)10;
            Console.WriteLine("Random day: {0}", notInEnum); // Returns: 10 (value of random if not in Enum)
            Console.WriteLine("Get name using Enum class: {0}", Enum.GetName(typeof(DaysInWeek), 6)); // Returns: Monday

            Console.WriteLine("----------------------------------------");

            foreach (short val in Enum.GetValues(typeof(DaysInWeek)))
            {
                Console.WriteLine($"{val} - {(DaysInWeek)val}");
            }

            Console.WriteLine("----------------------------------------");

            foreach (var name in Enum.GetNames(typeof(DaysInWeek)))
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("----------------------------------------");

            if (Enum.TryParse<DaysInWeek>("Wednesday", out DaysInWeek dayOfWeek))
                Console.WriteLine($"{dayOfWeek}");
        }
    }
}
