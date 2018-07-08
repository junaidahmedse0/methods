using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Enter number:: ");
            number = int.Parse(Console.ReadLine());
            int deciNum=ConvertNum(number);
            Console.WriteLine("Decimal number is:: " + deciNum);
            Console.ReadKey();
            
        }
        static int ConvertNum(int num)
        {
            int deci = 0,remainder;
            while (num > 0)
            {
                deci = (deci * 10) + num % 10;
                num = num / 10;
            }

            return deci;

        }
    }
}
