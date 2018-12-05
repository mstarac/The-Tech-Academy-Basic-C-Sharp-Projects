using System;



class Program
{
    static void Main()
    {
        //Number 1
        Console.WriteLine("Please enter a number");
        int numberFifty = 50;
        int numberYour = Convert.ToInt32(Console.ReadLine());
        long totalYour = numberFifty * numberYour;
        Console.WriteLine("The number entered times 50 is: " + totalYour);
        Console.ReadLine();

        //Number 2
        Console.WriteLine("Please enter a number");
        int numberTwentyFive = 25;
        int numberEntered = Convert.ToInt32(Console.ReadLine());
        int totalBoth = numberEntered + numberTwentyFive;
        Console.WriteLine("Your number plus 25 is: " + totalBoth);
        Console.ReadLine();

        //Number 3
        Console.WriteLine("Please enter a number");
        int numberDivided = Convert.ToInt32(Console.ReadLine());
        double numberTwelvePointFive = 12.5;
        int dividedTotal = numberDivided / Convert.ToInt32(numberTwelvePointFive);
        Console.WriteLine("Your number divided by 12.5 is: " + dividedTotal);
        Console.ReadLine();

        //Number 4
        Console.WriteLine("Please enter a number");
        int numberGreater = Convert.ToInt32(Console.ReadLine());
        bool greaterThan = numberGreater > numberFifty;
        Console.WriteLine("Let's see if your number is greater than 50: " + greaterThan);
        Console.ReadLine();

        //Number 5
        Console.WriteLine("Please enter a number");
        int numberRemainder = Convert.ToInt32(Console.ReadLine());
        int numberSeven = 7;
        int numberRemainderTotal = numberRemainder % numberSeven;
        Console.WriteLine("The number's remainder is: " + numberRemainderTotal);
        Console.ReadLine();





    }
}
