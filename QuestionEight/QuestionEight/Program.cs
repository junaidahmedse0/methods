using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionEight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:: ");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Enter Second Number:: ");
            string secondNumber = Console.ReadLine();
            string result = SumTowNumberByDigits(firstNumber,secondNumber);
            Console.WriteLine(result);
            Console.ReadKey();


        }
        static string SumTowNumberByDigits(string firstNumber, string secondNumber)
        {
            int[] firstArray = new int[Math.Max(firstNumber.Length, secondNumber.Length)];
            int[] secondArray = new int[Math.Max(firstNumber.Length, secondNumber.Length)];
            int[] sumArray = new int[Math.Max(firstNumber.Length, secondNumber.Length)];
            StringBuilder sb = new StringBuilder();
            sb.Append(firstNumber);
            for (int i = 0; i < firstNumber.Length; i++)
            {

                firstArray[i] = Convert.ToInt32(sb[firstNumber.Length - 1 - i].ToString());
            }
            sb.Clear();
            sb.Append(secondNumber);
            for (int i = 0; i < secondNumber.Length; i++)
            {

                secondArray[i] = Convert.ToInt32(sb[secondNumber.Length - 1 - i].ToString());
            }
            sb.Clear();
            int number = 0;
            for (int i = 0; i < Math.Max(firstNumber.Length, secondNumber.Length); i++)
            {
                if (i == 0)
                {
                    sumArray[i] = (firstArray[i] + secondNumber[i] % 10);
                }
                else if (i == Math.Max(firstNumber.Length, secondNumber.Length))
                {
                    sumArray[i] = (firstArray[i - 1] + secondNumber[i]) % 10 + (firstArray[i]);
                }
                else
                {
                    sumArray[i] = (firstArray[i] + secondArray[i]) % 10 + (firstArray[i - 1] + secondArray[i - 1]) / 10 + number;
                    number = 0;
                    if (sumArray[i] > 9)
                    {
                        number = sumArray[i] / 10;
                        sumArray[i] = sumArray[i] % 10;
                    }
                }

            }
            Array.Reverse(sumArray);
            if (sumArray[0] != 0)
            {
                sb.Append(sumArray[0]);

            }
            for (int i = 1; i < Math.Max(firstNumber.Length, secondNumber.Length); i++)
            {

                sb.Append(sumArray[i]);

            }

            return sb.ToString();
            
        }




    }
}
