using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroduceGame();
        }

        public static void IntroduceGame()
        {
            // Introduce player to the game 
            Console.WriteLine("Welcome contestant!");

            newGame();

            static void newGame()
            {
                Console.WriteLine("Take a guess what I'm thinking..." +
                    "Any number between 0 and 100.");

                // Create random number between 0 and 100
                var numberToGuess = new Random().Next(101);

                // Create a variable to store the host guess
                var numberChoice = numberToGuess;
                Console.WriteLine(numberChoice);

                // set a variable called guessLoop to true
                var guessLoop = true;

                while (guessLoop is true)
                {
                    // Ask the user for their guess
                    Console.Write("Enter a number: ");

                    // Parse the result as an integer
                    int userGuess = Convert.ToInt32(Console.ReadLine());

                    // If host choice is the same as user choice
                    if (numberChoice == userGuess)
                    {
                        Console.WriteLine("Congratulations, you have guessed the right number.");
                        guessLoop = false;

                        // Ask the user if they want to play again
                        Console.Write("Do you want to play again?Type 1 for yes: ");

                        // Convert user choice from a string to an integer
                        int playAgain = Convert.ToInt32(Console.ReadLine());

                        // If user selects 1 for yes then game reloads
                        if (playAgain == 1)
                        {
                            newGame();
                        }
                        else
                        {
                            Console.WriteLine("Thank you for playing this Guessing Game of Doom.");
                        }
                    }
                    // If host choice is less than user choice
                    else if (numberChoice < userGuess && userGuess < 100)
                    {
                        Console.WriteLine("The number you have guessed is too high.");
                        Console.Write("Try again. ");

                    }
                    // If host choice is greater than user choice
                    else if (numberChoice > userGuess && userGuess < 100)
                    {
                        Console.WriteLine("The number you have guessed is too low.");
                        Console.Write("Try again. ");
                    }
                    // If there is an invalid entry repeat while loop
                    else
                    {
                        Console.WriteLine("Not a Valid Entry.");
                    }
                }
                // Should have error checking of invalid data
                // We end thanks message

            }

        }



    }
}
