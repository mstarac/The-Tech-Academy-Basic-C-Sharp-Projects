﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();


            // Casting
            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            // int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m;

            double heightInCentimeters = 211.30202092;

            float secondsLeft = 2.62f;

            short temperatureOnMars = -342;

            string myName = "Tarra";

            // Casts - changing from one data type to another

            // Here we will convert from an integer to a string

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            // Here we convert a boolean

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);


            Console.WriteLine(rainingStatus);
            Console.ReadLine();
        }
    }
}
