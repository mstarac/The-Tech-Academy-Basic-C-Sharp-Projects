

// Do While
using System;


namespace DoWhileDrill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Where does Santa Claus live?");
            bool correctAnswer = (Console.ReadLine() == "The North Pole");
            while (!correctAnswer)
            {
                Console.WriteLine("You are incorrect, try again. Let's try it again.");
                Console.WriteLine("Where does Santa Claus live?");
                break;


            }
            do
            {


                Console.WriteLine("Where does Santa Claus live in the summer?");
                correctAnswer = (Console.ReadLine() == "Hawaii");
            } while (!correctAnswer);



            Console.WriteLine("That's what I've been told.");
            Console.ReadLine();





        }
    }
}


