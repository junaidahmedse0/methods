using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace QuestionTen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for Sorting a number::  ");
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial=Factorial(number);
            Console.WriteLine("Factorial of Number:: " + factorial);
            Console.ReadKey();

        }
        static BigInteger Factorial(int num)
        {
            BigInteger factorial = 1;
            while(num>0)
            {
                factorial=factorial* num;
                num--;
            }
            return factorial;
        }
    }
}
