using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionEleven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-REVERSE:: ");
            Console.WriteLine("2-Average:");
            Console.WriteLine("3-Equation:");
            Console.WriteLine("4-EXIT");
            int num = int.Parse(Console.ReadLine());
            switch(num)
            {

                case 1:
                    Console.WriteLine("Enter number for Reverse::");
                    int number = int.Parse(Console.ReadLine());
                    int reverse = Reverse(number);
                    Console.WriteLine("Your Reverse Number is:: " + reverse);
                    break;

                case 2:
                    int average = Average();
                    Console.WriteLine("The average of numbers:: " + average);
                    break;

                case 3:
                    int ans = SolveByEquation();
                    Console.WriteLine("The answer by Solved Equation" + ans);
                    break;

                case 4:
                    Environment.Exit(-1);
                    break;
            }
            Console.ReadKey();
        }

        static int Reverse(int num)
        {
            int dec = 0;
            while (num > 0)
            {
                dec = dec * 10 + num % 10;
                num = num / 10;
             }

            return dec;
        }
        static int Average()
        {
            Console.WriteLine("Enter how much number you want to enter::");
            int nums = int.Parse(Console.ReadLine());
            int[] array = new int[nums];
            int sum = 0;
            int count = 0;
            int average;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum = sum + array[i];
                count++;

            }
            average = sum / count;
            // Console.WriteLine("The average is:: " + average);
            return average;

        }
        static int SolveByEquation()
        {
            int a = 0;
            do
            {
                Console.WriteLine("Enter a:: ");
                a = int.Parse(Console.ReadLine());
            } while (a == 0);
            Console.WriteLine("Enter b:: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:: ");
            int b = int.Parse(Console.ReadLine());
            return a * x + b;
        }


    }
}
