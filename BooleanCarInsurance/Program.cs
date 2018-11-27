using System;


namespace BooleanCarInsurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            byte ageYour = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Answer true or false");
            bool hadADui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            byte speedingTickets = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Does the applicant qualify for car insurance?");
            Console.WriteLine(ageYour > 15 && !hadADui && speedingTickets < 4);
            Console.ReadLine();

        }
        
    }
}
