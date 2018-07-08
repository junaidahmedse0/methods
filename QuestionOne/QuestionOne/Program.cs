using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter a Name:: ");
            name = Console.ReadLine();
            PrintName(name);
            Console.ReadKey();

        }
        static void PrintName(string name)
        {

            Console.WriteLine("Hello, {0}",name);
        }
    }
}
