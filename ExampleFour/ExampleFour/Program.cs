using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:: ");
            // int[] number = Sort{ 10,9,8,7);
            int[] numbers = Sort(10, 3, 5, -1, 0, 12, 8);
            printNumbers(numbers);

            Console.ReadKey();
        }
      
        static void printNumbers(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(" " + numbers[i]);
                if (i < (numbers.Length-1))
                {
                    Console.Write(", ");
                }

            }

        }
        static int[] Sort(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++) {
                    if (numbers[i] > numbers[j])
                    {

                        int oldNum = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = oldNum;

                    }

                }



            }

            return numbers;
        }



    }
}
