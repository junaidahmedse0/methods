using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int  month1, month2;
            Console.WriteLine("Enter First number of Month::");
            month1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number of Month::");
            month2 = int.Parse(Console.ReadLine());
            int period = month2 - month1;
            Console.WriteLine("The difference {0} between first month {1} and second month {2}",period,GetName(month1),GetName(month2));
            Console.ReadKey();


        }

        static string GetName(int numOfMonth)
        {
            string monthName = "";

            switch (numOfMonth)
            {
                case 1:
                    monthName = "january";
                    break;
                case 2:
                    monthName = "fabruary";
                    break;

                case 3:
                    monthName = "march";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "Octobar";

                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
                default:
                    Console.WriteLine("Enter Correct Number of Month");
                    return null;
                    break;




            }

            return monthName;
        }
    }
}
