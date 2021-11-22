using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class Power_Two
    { 
        //method
            public void Power()
            {
            //initialization
            int number;
            //take input
                Console.WriteLine("Enter the Power");
            //read input
                number=int.Parse(Console.ReadLine());
            //for loop
                if (number > 0 && number < 31)
                {
                    for (int i = 0; i < number; i++)
                    {
                        Console.WriteLine("2^{0} = {1} ", i, Math.Pow(2, i));
                    }
                }

            }
        }
    }


