using System;
using System.Collections.Generic;

namespace StringsAndArraysDrill
{
    class Program
    {
        static void Main()
        {
            //1. Create an array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.
            //2. Create an array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
            //3. Add in a message that displays when the user selects an index that doesn’t exist.
            //4. Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.


            string[] animalArray = new string[] { "lion", "camel", "bird", "monkey", "llama" };
            Console.WriteLine("Select a number between 0 and 5 to see which animal you will feed here at the zoo");
            int selectFirst = Convert.ToInt32(Console.ReadLine());
            if (selectFirst > 5)
            {
                Console.WriteLine("You must pick a number between the ones specified.");
                selectFirst = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You will care for the " + animalArray[selectFirst]);

            int[] hoursWorked = new int[] { 15, 20, 25, 30, 35 };
            Console.WriteLine("Select a number between 0 and 4 to see how many weekly summer hours you will work");
            int selectSecond = Convert.ToInt32(Console.ReadLine());
            if (selectSecond > 4)
            {
                Console.WriteLine("You must pick a number between the ones specified.");
                selectSecond = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("You will work " + hoursWorked[selectSecond] + " hours.");

          
            List<string> habitatList = new  List<string>();
            habitatList.Add("jungle");
            habitatList.Add("rain forest");
            habitatList.Add("desert");
            habitatList.Add("highlands");
            habitatList.Add("grasslands");

            Console.WriteLine("Select a number between 0 and 5 to see which habitat you will be cleaning.");
            int selectThird = Convert.ToUInt16(Console.ReadLine());
            if (selectThird > 5)
            {
                Console.WriteLine("You will be cleaning the habitat " + habitatList[selectThird]);

                Console.ReadLine();


            }

        }   
            
    }
}

        








