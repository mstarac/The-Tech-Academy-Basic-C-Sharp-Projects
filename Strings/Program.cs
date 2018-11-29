using System;


namespace Strings
{
    class Program
    {
        static void Main()
        {
            //1. Concatenate three strings.
            string name = "His name is Huey." + "His name is Dewey." + "His name is Louie.";
            Console.WriteLine(name);
            Console.ReadLine();

            //2. Convert a string to uppercase.
            string name = "please convert me to uppercase.";
            name = name.ToUpper();
            Console.WriteLine(name);
            Console.ReadLine();

            //3. Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            StringBuilder sb = new StringBuilder();
            sb.Append("On the first day of Christmas my true love gave to me,");
            sb.Append("A partridge in a pear tree.");
            sb.Append("On the second day of Christmas my true love gave to me,");
            sb.Append("Two turtle doves and a partridge in a pear tree.");
            sb.Append("On the third day of Christmas my true love gave to me,");
            sb.Append("Three french hens, two turtle doves, and a patridge in a pear tree.");
            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
