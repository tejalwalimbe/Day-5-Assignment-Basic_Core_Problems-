using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class Flip_Coin
    {
       
            // initialization
            public double TailCount = 0;
            public double HeadCount = 0;
            public double Tail = 0;
            public double Head = 0;

            // method
        
        public void FlipCoinProgram()
        {
            int number;
        
            {
                Console.WriteLine("Enter the number of Times you want to Flip Coin ");
                number=int.Parse(Console.ReadLine());

                Random r = new Random();

                // n time loop will run
                for (int i = 0; i < number; i++)
                {
                    // random Possiblity
                    int coin = r.Next(0, 2);

                    if (coin < 0.5)
                    {
                        Console.WriteLine("Value:Tails");
                        TailCount = TailCount + 1;
                    }
                    else
                    {
                        Console.WriteLine("Value:Head");
                        HeadCount = HeadCount + 1;
                    }
                }
                //To find Percentage
                Tail = TailCount / number * 100;
                Head = HeadCount / number* 100;
                Console.WriteLine("Percentage of Tail is " + Tail);
                Console.WriteLine("Percentage of Head is " + Head);
            }

        }
    }
}