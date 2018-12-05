using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {

            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);

            //Example of another list with string
            //List<string> intList = new List<string>();
            //intList.Add("Hello");
            //intList.Add("Jesse");
            //intList.Remove("Jesse");

            Console.WriteLine(intList[0]);
            Console.ReadLine();


            //Creating Arrays
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //This example does the same as above
            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            //It would be followed by
            //Console.WriteLine(numArray1[3]);
            //Console.ReadLine();

            //Another example of creating a new array
            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

            //Console.WriteLine(numArray2[3]);
            //Console.ReadLine();

            //To make a change to the above array (600) we would do the following
            //numArray2[5] = 650;

            //Console.WriteLine(numArray2[5]);
            //Console.ReadLine();


            //This is for the original example
            //Console.WriteLine(numArray[3]);
            //Console.ReadLine();
        }
    }
}
