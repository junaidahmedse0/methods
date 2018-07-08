using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFour1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:: ");
            int num = int.Parse(Console.ReadLine());
            string englishNum = EnglishLastNum(num);
            Console.WriteLine("Last Num:: "+englishNum);

            Console.ReadKey();
        }
        static string EnglishLastNum(int dec)
        {
            int digit = dec % 10;
            string englishNum = "";
            switch (digit)
            {

                case 1:
                    englishNum = "One";
                    break;
                case 2:
                    englishNum = "Two";
                    break;
                case 3:
                    englishNum = "Three";
                    break;
                case 4:
                    englishNum = "Four";
                    break;
                case 5:
                    englishNum = "Five";
                    break;
                case 6:
                    englishNum = "Six";
                    break;
                case 7:
                    englishNum = "Seven";
                    break;
                case 8:
                    englishNum = "Eight";
                    break;
                case 9:
                    englishNum = "Nine";
                    break;
               



            }
            return englishNum;


        }

    }
}
