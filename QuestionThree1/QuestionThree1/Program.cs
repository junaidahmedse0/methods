using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionThree1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 5, 6, 6, 7 };
            Console.WriteLine("Enter number Repeatness:: "); 
            int number = int.Parse(Console.ReadLine());
            int count = CountIntegerNum(number, num);
            Console.WriteLine("Count:: " + count);
            Console.ReadKey();
        }

        static int CountIntegerNum(int num, int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] == num)
                {

                    count++;
                }


            }
            return count;



        }
    }
}
