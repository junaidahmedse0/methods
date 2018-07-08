using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2 };
            int num= GetMax(numbers);
             Console.WriteLine("Maximum number is:: "+num);
            int[] numbers2 = { 1, 2, 3, 4, 5 };
            num = GetMax(numbers2);
            Console.WriteLine("Maximum number is::" + num);

            Console.ReadKey();
        }
        static int GetMax(params int[] numbers)
        {
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {


                    max = numbers[i];

                }



            }

            return max;

        }
    }
}
