using System;

namespace Enumeration
{
    public enum DaysInWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            var day = DaysInWeek.Monday;
            
            Console.WriteLine("Day of week: {0}", (int) day);
        }
    }
}
