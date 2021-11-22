using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
      class Swap_numbers
        {
           public void Swapping()
        { 
                int num1, num2, temp;

                Console.WriteLine("Enter the First Number:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Second Number:");
                num2 = int.Parse(Console.ReadLine());
                temp = num1;
                num1 = num2;
                num2 = temp;

                Console.WriteLine("\n After Swapping :");
                Console.WriteLine("\n First Number :" + num1);
                Console.WriteLine("\n Second Number :" + num2);
                Console.ReadLine();
            }
        }
    }
