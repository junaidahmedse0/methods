using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            double farhietTemp = 0;
            double celciusTemp = 0;
            Console.WriteLine("Enter Farenhiet Temprature:: ");
            farhietTemp = double.Parse(Console.ReadLine());
            celciusTemp = farenhietToCelcius(farhietTemp);
            Console.WriteLine("Your body temprature is:: "+celciusTemp);
            if (celciusTemp > 37)
            {
                Console.WriteLine("Your body temprature is Greater than 37 You are ill");


            }
            Console.ReadKey();

        }
       static double  farenhietToCelcius(double farenhietTemp)
        {
           double  celciusTemp =((farenhietTemp - 32)*5/9);
            return celciusTemp;

        }
    }
}
