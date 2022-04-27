using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Please select which program would you like to use today and input a number:\n 1: Print integer 1000 to -1000.\n " +
                "2: Print numbers 3 through 999 by 3 each time.\n 3: To check whether they two numbers are equal or not.\n" +
                " 4: To check whether a given number is even or odd.\n 5: To check whether a given number is positive or negative.\n" +
                " 6: To read the age of a candidate and determine whether they can vote.\n 7: To check if an integer (from the user) is in the range -10 to 10.\n" +
                " 8: To display the multiplication table (from 1 to 12) of a given integer.");
            Console.WriteLine();
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    PrintOneThousand();
                    break;

                case "2":
                    PrintThreeToNine();
                    break;

                case "3":
                    Two2Integers();
                    break;

                case "4":
                    EvenOrOdd();
                    break;

                case "5":
                    PositiveorNegative();
                    break;

                case "6":
                    VoteOrNote();
                    break;

                case "7":
                    BetweenTenToTen();
                    break;

                case "8":
                    MultiplicatonTable();
                    break;

                default:
                    {
                        Console.WriteLine("Please enter a valid input!");
                        break;
                    }
             }
            
        }

        public static void PrintOneThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintThreeToNine()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static void Two2Integers()
        {
            Console.WriteLine("Please enter the first integer:");
            var userInput = Console.ReadLine();
            Console.WriteLine("Please enter the second integer:");
            var userInput2 = Console.ReadLine();
            if (userInput == userInput2)
            {
                Console.WriteLine("The numbers you entered are equal!");
            }
            else
            {
                Console.WriteLine("The numbers you entered are not equal!");
            }
        }

        public static void EvenOrOdd()
        {
            Console.WriteLine("This program check if a number is even or odd.");
            Console.WriteLine();
            Console.WriteLine("Please enter the number you want to check:");
            int num = int.Parse(Console.ReadLine());
            int checkVar = num % 2;

            if(num == 0)
            {
                Console.WriteLine("Please enter a valid input! (No zeroes allowed)");
            }
            if (checkVar == 0)
            {
                Console.WriteLine("The number you entered is EVEN!");
            }
            else
            {
                Console.WriteLine("The number you entered is ODD!");
            }
        }

        public static void PositiveorNegative()
        {
            Console.WriteLine("This program check if a number is positive or negative.");
            Console.WriteLine();
            Console.WriteLine("Please enter the number you want to check:");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("The number you entered is POSITIVE!");
            }
            else if (num < 0)
            {
                Console.WriteLine("The number you entered is NEGATIVE!");
            }
            else
            {
                Console.WriteLine("Please enter a valid input! (No zeroes allowed)");
            }
        }

        public static void VoteOrNote()
        {
            Console.WriteLine("This program checks the eligibility to vote!");
            Console.WriteLine();
            Console.WriteLine("Please enter the age to check the potential voter's eligibility:");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput >= 18)
            {
                Console.WriteLine("Your potential voter CAN vote in this elections!");
            }
            else
            {
                Console.WriteLine("Your potential voter CANNOT vote in this elections!");
            }
        }


        public static void BetweenTenToTen()
        {
            Console.WriteLine("This program checks if the integer is in the range of -10 to 10");
            Console.WriteLine();
            Console.WriteLine("Please enter an integer:");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput >= -10 && userInput <= 10)
            {
                Console.WriteLine("The integer you entered is WITHIN the range!");
            }
            else
            {
                Console.WriteLine("The integer you entered is NOT WITHIN the range!");
            }
        }

        public static void MultiplicatonTable()
        {
            Console.WriteLine("This program shows the multiplication table of a given integer.");
            Console.WriteLine();
            Console.WriteLine("Please enter an integer to get its multiplication table:");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} * {i} = {num*i}");
            }
        }
    }
}
