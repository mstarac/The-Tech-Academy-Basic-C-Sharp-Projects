using System;



class Program
{
    static void Main()
    {
        // Step 1
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");
        Console.WriteLine("Press Enter");
        Console.ReadLine();

        // Step 2
        Console.WriteLine("What course are you on?");
        string yourCourse = Console.ReadLine();
        Console.WriteLine("Course you are on: " + yourCourse);
        Console.WriteLine("Press Enter");
        Console.ReadLine();

        //Step 3
        Console.WriteLine("What page number?");
        string pageNumber = Console.ReadLine();
        Console.WriteLine("You are on page: " + pageNumber);
        Console.WriteLine("Press Enter");
        Console.ReadLine();

        //Step 4
        Console.WriteLine("Do you need anything? Please answer “true” or “false”");
        bool needHelp = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Press Enter");
        Console.ReadLine();

        //Step 5
        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
        string yourPositiveExperiences = Console.ReadLine();
        Console.WriteLine("Positive Experiences: " + yourPositiveExperiences);
        Console.WriteLine("Press Enter");
        Console.ReadLine();

        // Step 6
        Console.WriteLine("Is there any other feedback you'd like to provide? Please give specifics");
        string yourFeedback = Console.ReadLine();
        Console.WriteLine("Other feedback: " + yourFeedback);
        Console.WriteLine("Press Enter");
        Console.ReadLine();

        // Step 7
        Console.WriteLine("How many hours did you study today?");
        string hoursStudied = Console.ReadLine();
        Console.WriteLine("Hours you studied: " + hoursStudied);
        Console.WriteLine("Press Enter");
        Console.ReadLine();

        //Step 8
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.WriteLine("Press Enter");
        Console.ReadLine();

    }
}

