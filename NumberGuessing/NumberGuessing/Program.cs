// Author: Mathew Argue
// CS 364
// Project #1

using System;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Constants
            const bool EXIT_CODE = true;
            const int MIN_RANGE = 1;
            const int MAX_RANGE = 51;
            #endregion

            #region Variable Declarations
            Random rnd = new Random();
            int rNumber = rnd.Next(MIN_RANGE, MAX_RANGE);
            int guess;
            int guessCount = 0;
            bool quit = false;
            #endregion

            PrintInstructions();

            #region Main Program Loop
            while (!quit)
            {
                // Attempt to parse the string to an integer
                if (int.TryParse(Console.ReadLine(), out guess))
                {

                    // Validate that the user's guess is within the random number range
                    if (guess >= 1 && guess <= 50)
                    {
                        guessCount++;

                        // Correct answer was entered
                        if (guess == rNumber)
                        {
                            Console.Clear();
                            Console.WriteLine("You got it! The number was " + guess);
                            Console.WriteLine("It took " + guessCount + " trys to get it!\n");
                            guessCount = 0;

                            // Start a new round
                            rNumber = rnd.Next(MIN_RANGE, MAX_RANGE);
                            Console.WriteLine("Guess the number between 1 and 50! If you would like to quit, enter 0.\n");
                        }

                        // The guess was lower than the answer
                        else if (guess < rNumber)
                        {
                            Console.WriteLine("Too low! Try a higher number!\n");
                        }

                        // The guess was higher than the answer
                        else if (guess > rNumber)
                        {
                            Console.WriteLine("Too high! Try a lower number!\n");
                        }
                    }

                    // Quit Game
                    else if (guess == 0)
                    {
                        Console.WriteLine("Thanks for playing!\n");
                        quit = EXIT_CODE;
                    }

                    // The guess was outside the random number range
                    else if (guess < 0 || guess > 50)
                    {
                        Console.WriteLine("You're wayyyy off! Keep it within 1 and 50 ;)\n");
                    }
                }

                // Could not parse the user's input as an integer
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
            #endregion
        }

        static void PrintInstructions()
        {
            Console.WriteLine("Try to guess a random number between 1 and 50.");
            Console.WriteLine("Press enter once you have entered your number ;)");
            Console.WriteLine("To quit at any time, enter 0\n");
        }
    }
}

