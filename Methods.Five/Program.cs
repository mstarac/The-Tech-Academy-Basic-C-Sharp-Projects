using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Five
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number and we will divide it by two.");
            int oneInput = Convert.ToInt32(Console.ReadLine());

            ClassDivider classDivider = new ClassDivider();
            classDivider.Division(oneInput, out int outcome);
            Console.WriteLine("Your number divided by two: " + outcome);
            Console.ReadLine();

            Console.WriteLine("Please enter another number and we will divide it by two.");
            decimal twoInput = Convert.ToInt32(Console.ReadLine());
            decimal outcomeTwo = 0;

            ClassDivider.Division(twoInput, out outcomeTwo);
            Console.WriteLine(outcomeTwo);
            Console.ReadLine();


                

        }
    }
}
