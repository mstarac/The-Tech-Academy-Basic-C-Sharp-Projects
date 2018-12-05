using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExamples
{
    class Program
    {
        static void Main(string[] args)
        { 
          
        Console.WriteLine("Guess a number?");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isGuessed = number ==12;

            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. That are correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }

            while (!isGuessed);
        
         Console.Read();

}
    }
}


// Here the program ends if number guessed wrong
//Console.WriteLine("Guess a number?");
//int number = Convert.ToInt32(Console.ReadLine());

//switch (number)
//{
//case 62:
//Console.WriteLine("You guessed 62. Try again.");
// break;
//case 29:
//Console.WriteLine("You guessed 29. Try again.");
// break;
//case 55:
//Console.WriteLine("You guessed 55. Try again.");
//break;
//case 12:
//Console.WriteLine("You guessed the number 12. You are correct!");
//break;
//default:
//Console.WriteLine("You are wrong.");
//break;



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




