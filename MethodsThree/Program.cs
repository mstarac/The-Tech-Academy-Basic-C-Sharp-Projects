using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsThree
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int input = Convert.ToInt32(Console.ReadLine());


            Class class1 = new Class();
            int  input1 = 12;
            Console.WriteLine(class1.DoMath(input1));
            Console.ReadLine();

            Class class2 = new Class();
            decimal input2 = .25m;
            Console.WriteLine(class2.DoMath(input2));
            Console.ReadLine();

            Class class3 = new Class();
            string input3 = "100";
            Console.WriteLine(class2.DoMath(input3));
            Console.ReadLine();


           

        }
    }
}
