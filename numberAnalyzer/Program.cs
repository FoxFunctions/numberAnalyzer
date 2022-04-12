using System;

namespace numberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, what is your name?");
            string userName = Console.ReadLine();
            bool continueLoop = true;
            int userNumber = 0;

            while (continueLoop)

            {   while (true)
                {
                    Console.WriteLine($"Okay, {userName} please enter a number between 1 and 100");
                    int userInput = int.Parse(Console.ReadLine());
                    if (userInput >= 1 && userInput <= 100)
                    {
                        userNumber = userInput;
                        Console.WriteLine($"Okay {userName}. Your number is {userNumber}.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"C'mon! Please Follow instructions!");
                    }
                }

                if (userNumber % 2 != 0)
                {
                    if ( userNumber < 60)
                    {
                        Console.WriteLine($"{userNumber} is odd and less than 60");
                    }
                    else if (userNumber > 60)
                    {
                        Console.WriteLine($"{userNumber} is odd and greater than 60");
                    }
                }

                if (userNumber % 2 == 0)
                {
                    if (userNumber <= 25)
                    {
                        Console.WriteLine($"{userNumber} is even and less than 25.");
                    }
                    else if (userNumber > 25 && userNumber <= 60)
                    {
                        Console.WriteLine($"{userNumber} is even and betwwen 26 and 60 inclusive.");
                    }
                    else if (userNumber > 60)
                    {
                        Console.WriteLine($"{userNumber} is even and greater than 60.");
                    }    
                }
                while (true)
                {
                    Console.WriteLine($"Say, {userName}. Would you like to run this program again? y/n");
                    string userContinue = Console.ReadLine().ToLower();

                    if (userContinue == "y")
                    {
                        Console.WriteLine("You got it dude!");
                        break;
                    }
                    else if (userContinue == "n")
                    {
                        Console.WriteLine("Goodbye");
                        continueLoop = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"I'm sorry, I didn't quite get that, {userName}. Please enter y/n");
                        continue;
                    }
                }
            }
        }
    }
}





/* 1 Point: Use if/else statements to take different actions depending on user input.  
Given an integer entered by a user, perform the following conditional actions:
1 Point: If the integer entered is odd and less than 60, print the number entered and “Odd and less than 60.”
1 Point: If the integer entered is even and in the inclusive range of 2 to 24, print “Even and less than 25.”
1 Point: If the integer entered is even and in the inclusive range of 26 to 60, print “Even and between 26 and 60 inclusive.”
1 Point: If the integer entered is even and greater than 60, print the number entered and “Even and greater than 60.”
1 Point: If the integer entered is odd and greater than 60, print the number entered and “Odd and greater than 60.”

Additional Requirements:
1 Point: For answering the Lab Summary when submitting to the LMS
-2 Points: if there are any syntax errors or if the program does not run (for example, in a Main method). 

Hints:
Remember what “inclusive” and “exclusive” mean when referring to ranges of numbers. The range of numbers from 1 inclusive to 10 exclusive means the numbers 1, 2, 3, 4, 5, 6, 7, 8, 9 (but not 10; it’s excluded).

Extra Challenges (2 Points Maximum):
1 Point: Set up the program to continue running with a prompt at the end to see if they want to stop. (hint: Loops)
1 Point: Ask for user information (ex. name) at the beginning of the application, and use it to refer to the user throughout the application.
1 Point: Add validation to guarantee that a user enters a positive integer between 1 and 100. */




