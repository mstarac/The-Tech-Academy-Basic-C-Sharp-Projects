using System;


namespace PackageExpressBranching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter weight of package:");
            float weight = Convert.ToSingle(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("ERROR: Package too heavy to be shipped via Package Express. Have a nice day.");
                Console.ReadLine();
            }
            
                Console.WriteLine("Please enter width of your package:");
                float width = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Please enter height of your package");
                float height = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Please enter length of your package");
                float length = Convert.ToSingle(Console.ReadLine());

                if (width + height + length > 50)
                {
                    Console.WriteLine("ERROR: Package too big to be shipped via Package Express.");
                    Console.ReadLine();

                }

                float quote = ((width + length + height) * weight) / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + Math.Round(quote, 2));
                Console.ReadLine();

                 }

               }

            }
            