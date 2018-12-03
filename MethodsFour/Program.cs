using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsFour
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassOptional outcome = new ClassOptional();

            Console.WriteLine("Please enter a number.");
            int oneInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a second number (optional).");
            string input = Console.ReadLine();
            int twoInput = 0;
            if (!string.IsNullOrEmpty(input))
            {
                twoInput = Convert.ToInt16(input);
                outcome.optionalModifier(oneInput, twoInput);
                Console.WriteLine("Your first modified input is " + outcome.x + "and your second modified input is " + outcome.z);
            }
            else 
            {
                outcome.optionalModifier(oneInput);
                Console.WriteLine("Your first modified entry is " + outcome.x);
            }

            Console.ReadLine();
        }
    }
}
