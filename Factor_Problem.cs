using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class Factor_Problem
    {
        //method
        public void Factor()
        {
            //initialization
            int number;
            Console.WriteLine("Enter a number");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Prime factors of {0} are ", number);
            //condition
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}

        
    
