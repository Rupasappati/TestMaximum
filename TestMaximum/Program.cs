// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    class Program
    {


        static void Main(string[] args)
        {
            // Welcome Message
            Console.WriteLine("\n");
            Console.WriteLine("------------Welcome to Find the Maximum Number Program----------");
            Console.WriteLine("\n");

            //Calling Class to call a Function
            MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();
            int outputInteger = maximumNumberCheck.MaximumIngerNumber(11, 22, 33);

            //Display Output
            Console.WriteLine("Maximum Number of Integer : " + outputInteger);

            Console.ReadLine();
        }
    }
}