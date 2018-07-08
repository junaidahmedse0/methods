using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            CheckArray(array);
            Console.ReadKey();
            
        }

        static void CheckArray(int[] arryNumbers)

        {
            int firstBigIndex = 0;
            for (int index=0;index<arryNumbers.Length;index++)
            {
                int firstBig = arryNumbers[index];
                if ((firstBig > arryNumbers[index + 1]) && (firstBig > arryNumbers[index - 1]))
                {


                    firstBigIndex = index;
                    break;

                }
                else
                {
                    firstBigIndex = -1;
                }


            }
            Console.WriteLine("The index is:: "+firstBigIndex);

        }
    }
}
