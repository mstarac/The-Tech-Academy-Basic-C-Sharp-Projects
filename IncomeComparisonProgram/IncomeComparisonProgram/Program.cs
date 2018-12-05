using System;



class Program
{
    static void Main()
    {

        Console.WriteLine("Anonymous Income Comparison Program");
        Console.WriteLine("Person 1");
        Console.WriteLine("Hourly Rate:");
        int hourlyRateOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hours worked per week:");
        int hoursWorkedOne = Convert.ToInt32(Console.ReadLine());
        int salaryPersonOne = hourlyRateOne * hoursWorkedOne;
        Console.WriteLine("Press Enter");
        Console.ReadLine();

        Console.WriteLine("Person 2");
        Console.WriteLine("Hourly Rate:");
        int hourlyRateTwo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hours worked per week:");
        int hoursWorkedTwo = Convert.ToInt32(Console.ReadLine());
        int salaryPersonTwo = hourlyRateTwo * hoursWorkedTwo;
        Console.WriteLine("Press Enter");
        Console.ReadLine();

        Console.WriteLine("Person 1 Weekly Salary: " + salaryPersonOne);
        Console.WriteLine("Person 2 Weekly Salary: " + salaryPersonTwo);
       
        Console.WriteLine("Does Person 1 make more money than Person 2 ?" + (salaryPersonOne > salaryPersonTwo));
        Console.ReadLine();
    }

}
