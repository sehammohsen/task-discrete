using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the frist number");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("please enter the second number ");
            double n2 = double.Parse(Console.ReadLine());
            for (; n1 < n2; n1++)
            {
                int i = 2;
               for (; i <= Math .Floor(Math.Sqrt (n1)); i++)
               {
                        if (n1%i == 0)
                        break;
               } 
                if (n1 == 2) Console.WriteLine(n1);
                if (n1 % i != 0)
                    Console.WriteLine(n1);
            }
        }// project 1 prime number 
    }
}
