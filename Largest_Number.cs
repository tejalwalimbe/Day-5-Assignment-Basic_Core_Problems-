using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    public class LargestNumber
    {
        public void Largest()
        {


            //initialization
            int firstnumber, secondnumber, thirdnumber;

                Console.WriteLine("Enter the first number : ");
                firstnumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number : ");
                secondnumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the third number : ");
                thirdnumber = int.Parse(Console.ReadLine());
            //condition
                if (firstnumber > secondnumber)
                {
                    if (firstnumber > thirdnumber)
                    {
                        Console.WriteLine("Largest Number : " + firstnumber);
                    }
                    else
                    {
                        Console.WriteLine("Largest Number : " + thirdnumber);
                    }
                }
                else
                {
                    if (secondnumber > thirdnumber)
                    {
                        Console.WriteLine("Largest Number : " + secondnumber);
                    }
                    else
                    {
                        Console.WriteLine("Largest Number : " + thirdnumber);
                    }
                }
            }
        }
    }


