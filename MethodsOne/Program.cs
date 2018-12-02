
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOne
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOperationD1 = new MathOperation();

            Console.WriteLine("Please enter a number.");
            int amount = Convert.ToInt32(Console.ReadLine());
           
            
            oneMath.outcome1 = new oneMath(amount);
            twoMath.outcome2 = new twoMath(amount);
            threeMath.outcome3 = new threeMath(amount);


            Console.WriteLine(outcome1.a);
            Console.WriteLine(outcome2.b);
            Console.WriteLine(outcome3.c);
            Console.ReadLine();
        }
    }