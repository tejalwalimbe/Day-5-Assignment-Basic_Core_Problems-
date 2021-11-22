using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class Harmonic_Number
    {
        //method
            public void Harmonic()
            {
            //initialization
                double num = 0;
            int number;
                Console.WriteLine("Enter the value of HarmonicNumber ");
                number=int.Parse(Console.ReadLine());
            //for loop
                for (double i = 0; i < number; i++)
                {
                    double value = 1 / i;
                    num = num + value;
                    Console.WriteLine("Harmonic Number 1/{0} = {1} ", i, value);
                }
                Console.WriteLine("\n {0} th is the Harmonic Value of {1} ", number, num);
            }
        }
    }
