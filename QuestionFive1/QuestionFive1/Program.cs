using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFive1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Position in an array:: ");
            int position = int.Parse(Console.ReadLine());
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            CheckLarger(arr, position);
            Console.ReadKey();



        }
        static void CheckLarger(int[] arry,int position)
        {
            if (arry.Length == 1)
            {

                Console.WriteLine("Not any neighbour:: ");

            }
            else {
                if (position == 0)
                {

                    Console.WriteLine("The Comparable numbers are {0} and {1}", arry[position], arry[position + 1]);
                    Console.WriteLine("The bigger number is::" + Math.Max(arry[position], arry[position + 1]));


                }
                else if (position == arry.Length - 1)
                {
                    Console.WriteLine("The comparable numbers are {0} and {1}", arry[position], arry[position - 1]);
                    Console.WriteLine("The bigger number is: " + Math.Max(arry[position], arry[position - 1]));
                }
                else if ((position > 0) && (position < arry.Length - 1))
                {


                    Console.WriteLine("The comparabel numbers are {0},{1} and {2}", arry[position], arry[position + 1], arry[position - 1]);
                    Console.WriteLine("The bigger number is: " + Math.Max(Math.Max(arry[position], arry[position + 1]), arry[position - 1]));
                }
                else {

                    Console.WriteLine("There are no number in such osition");
                }


            }


        }

    }
}
