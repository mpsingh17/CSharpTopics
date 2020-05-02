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
            var day = DaysInWeek.Monday;

            var dayValue = (int) day;


            int random = 10;

            //Console.WriteLine("Day of week: {0}", day);
            //Console.WriteLine("Day of week Value: {0}", dayValue);

            //Console.WriteLine("Day of week: {0}", (DaysInWeek) dayValue);
            
            //Console.WriteLine("Random day: {0}", (DaysInWeek) random);

            var allDays = Enum.GetValues(typeof(DaysInWeek));

            
            foreach (var d in allDays)
            {
                Console.WriteLine((int)(DaysInWeek)d);
                //Console.WriteLine(Enum.GetName(typeof(DaysInWeek), (DaysInWeek) d));
                //Console.WriteLine(d);

            }
            Console.WriteLine("----------------------------------------");

            foreach (var name in Enum.GetNames(typeof(DaysInWeek)))
            {
                //Console.WriteLine(name == DaysInWeek.Monday.ToString());
                var result = Enum.Parse(typeof(DaysInWeek), name);
                Console.WriteLine((int) (DaysInWeek)result);
            }


        }
    }
}
