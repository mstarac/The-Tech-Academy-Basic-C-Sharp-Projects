//While
using System;


namespace WhileDrill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How many students are in the school?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool howManyStudents = number == 425;

            while (!howManyStudents)
            {
                switch (number)
                {
                    case 535:
                        Console.WriteLine("You guessed 535. Please try again.");
                        break;
                    case 300:
                        Console.WriteLine("You guessed 300. Please try again.");
                        break;
                    case 425:
                        Console.WriteLine("You guessed the number 425. That is correct!");
                        howManyStudents = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.Read();
        }
    }
}