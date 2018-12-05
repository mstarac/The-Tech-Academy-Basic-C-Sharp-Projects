using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escape Sequences - Here we learn to include quotes within a string with \, new line \n and tab \t, use \\ to include a slash,
            //@"" shows that everything is in quotes is part of the string
            string name = "Jesse";
            string quote = "The man said, \\Hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab.";
            string fileName = "C: \\Users\\Jesse";

            bool trueOrFalse = name.Console("s");

            //Console.WriteLine(trueOrFalse); This would be after the bool example
            //Console.ReadLine();


            int length = name.Length;

            //Console.WriteLine(length); This would follow the int example
            //Console.ReadLine();

            name = name.ToUpper();

            //Console.WriteLine(name); This would follow name ex
            // Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");

            //Console.WriteLine(sb);
            //Console.ReadLine();

            Console.WriteLine(quote);
            Console.ReadLine();
        }
    }
}
