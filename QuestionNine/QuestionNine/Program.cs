using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionNine
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {4,3,5,6,2,9,8,7 };
            int biggestNum = FindBiggest(array);
            Console.WriteLine("Biggest Number is::"+biggestNum);

            Console.ReadKey();

        }


        static int FindBiggest(int[] numbers)
        {
            int i = 0;
            int biggest = numbers[i];
            for (i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > biggest)
                {
                    biggest = numbers[i];

                }

            }
            return biggest;
        }
    }
}
