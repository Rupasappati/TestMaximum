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
            //Welcome Message
            Console.WriteLine("=-=-=-=-=-Welcome to the Find Maximum Problem using Generics-=-=-=-=-=");

            //Calling Class to call a Function
            MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();

            //Maximum Number of Integer
            int outputInteger = maximumNumberCheck.MaximumIngerNumber(11, 22, 33);
            Console.WriteLine("Maximum Number of Integer : " + outputInteger);

            //Maximum Number At First Place
            double outputFloat1 = maximumNumberCheck.MaximumFloatNumber(14.1, 2.82, 7.33);
            Console.WriteLine("Maximum Number of Float at First Place : " + outputFloat1);
            
            //Maximum Number At Second Place
            double outputFloat2 = maximumNumberCheck.MaximumFloatNumber(4.1, 28.2, 12.8);
            Console.WriteLine("Maximum Number of Integer at Second Place : " + outputFloat2);

            //Maximum Number At Third Place
            double outputFloat3 = maximumNumberCheck.MaximumFloatNumber(75.9, 68.47, 77.3);
            Console.WriteLine("Maximum Number of Integer at Third Place : " + outputFloat3);

            //Maximum Number At First Place
            string outputString1 = maximumNumberCheck.MaximumStringNumber("Peach", "Apple", "Banana");
            Console.WriteLine("Maximum Number of String at First Place : " + outputString1);

            //Maximum Number At Second Place
            string outputString2 = maximumNumberCheck.MaximumStringNumber("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum Number of String at Seond Place : " + outputString2);

            //Maximum Number At Third Place
            string outputString3 = maximumNumberCheck.MaximumStringNumber("Apple", "Banana", "Peach");
            Console.WriteLine("Maximum Number of String at Third Place : " + outputString3);


            Console.ReadLine();
        }
    }
}