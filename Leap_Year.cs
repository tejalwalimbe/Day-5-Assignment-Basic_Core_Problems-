using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class Leap_Year
    {
        //method
            public void CheckLeapYear()
            {
            //initialization
                int year;
            //input
                Console.Write("Enter the Year :");
                year=int.Parse(Console.ReadLine());
            //Condition
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    Console.WriteLine("Year is Leap Year");
                else
                    Console.WriteLine("Year is not a Leap Year");


                Console.ReadKey();
            }
        }
    }


