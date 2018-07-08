using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours;
            int minutes;
            bool correctTimeFormate = false;

            Console.WriteLine("Enter Hours::");
            hours = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Minutes:: ");
            minutes = int.Parse(Console.ReadLine());
            correctTimeFormate = IsHoursCorrect(hours) && IsMinutesCorrect(minutes);
            if (correctTimeFormate)
            {
                Console.WriteLine("That is time Now!" + hours + ":" + minutes);
            }
            else
                Console.WriteLine("Enter correct Format of time::");

            Console.ReadKey();

        }
        static bool IsHoursCorrect(int hours)
        {
            bool correct=false;
            if (hours > 0 && hours < 24)
            {
                correct = true;
            }
            return correct;
        }
        static bool IsMinutesCorrect(int minutes)
        {
            bool correct = false;
            if ( minutes> 0 && minutes < 60)
            {
                correct = true;
            }
            return correct;
        }
    }
}
