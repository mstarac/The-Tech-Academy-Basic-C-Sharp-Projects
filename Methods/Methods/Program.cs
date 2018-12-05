using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int value = Convert.ToInt32(Console.ReadLine());

            MathOne outcome1 = new MathOne(value);
            MathTwo outcome2 = new MathTwo(value);
            MathThree outcome3 = new MathThree(value);

            Console.WriteLine(outcome1.a);
            Console.WriteLine(outcome2.b);
            Console.WriteLine(outcome3.c);
            Console.ReadLine();
        }
    }

  