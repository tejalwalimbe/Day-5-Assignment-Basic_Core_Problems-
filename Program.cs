using System;

namespace Basic_Core_Programs
{

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("\t\t\t\t=====================List Of Basic Programs==================");
        Console.WriteLine();
        Console.WriteLine("\t\t\t\t\t\t1.Flip Coin");
        Console.WriteLine("\t\t\t\t\t\t2.Leap Year");
        Console.WriteLine("\t\t\t\t\t\t3.Power of 2");
        Console.WriteLine("\t\t\t\t\t\t4.Harmonic Number");
        Console.WriteLine("\t\t\t\t\t\t5.Factor");
        Console.WriteLine("\t\t\t\t\t\t6.Compute Quotient and Remainder");
        Console.WriteLine("\t\t\t\t\t\t7.Swap Two Numbers");
        Console.WriteLine("\t\t\t\t\t\t8.Even and Odd");
        Console.WriteLine("\t\t\t\t\t\t9.Alphabet is Vowel And Consonant");
        Console.WriteLine("\t\t\t\t\t\t10.Largest Among 3 numbers");

        int choice;
        Console.Write("\t\t\t\t\t\t ENTER YOUR CHOICE:");

        choice=int.Parse(Console.ReadLine());
        switch (choice)
        {
                case 1:
                    Console.WriteLine("Welcome To Flip Coin Program ");
                    Flip_Coin coin = new Flip_Coin();
                    coin.FlipCoinProgram();
                    break;

                case 2:
                    Console.WriteLine("Welcome to Year of Program ");
                    Leap_Year y = new Leap_Year();
                    y.CheckLeapYear();
                    break;

                case 3:
                    Console.WriteLine("Welcome to Power of 2 Program ");
                    Power_Two Power = new Power_Two();
                    Power.Power();
                    break;

                case 4:
                    Console.WriteLine("Welcome to Harmonic Number Program ");
                    Harmonic_Number harmonic = new Harmonic_Number();
                    harmonic.Harmonic();
                    break;

                case 5:
                    Console.WriteLine("Welcome to Factor Program ");
                    Factor_Problem factor = new Factor_Problem();
                    factor.Factor();
                    break;

                case 6:
                    Console.WriteLine("Welcome To Division Program ");
                    Remainder_quotient div = new Remainder_quotient();
                    div.Division();
                    break;

                case 7:
                    Console.WriteLine("Welcome To Swapping Program ");
                    Swap_numbers swap = new Swap_numbers();
                    swap.Swapping();
                    break;

                case 8:
                    Console.WriteLine("Welcome To Even and Odd Program");
                    Even_odd num = new Even_odd();
                    num.EvenOddFunction();
                    break;

                case 9:
                    Console.WriteLine("Welcome to Alphabet is Vowel And Consonant");
                    Alphabet alphabet = new Alphabet();
                    alphabet.Vowel();
                    break;


                case 10:
                    Console.WriteLine("Welcome to Largest Program ");
                    LargestNumber largest = new LargestNumber();
                    largest.Largest();
                    break;
            }
        }

    }
}
        
   
