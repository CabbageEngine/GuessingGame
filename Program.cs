using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            // Introduce player to the game 
            Console.WriteLine("Welcome contestant to the Guessing Game of Doom!");

            newGame();

            static void newGame()
            {
                Console.WriteLine("Take a guess what I'm thinking..." +
                    "Any number between 0 and 100.");

                // Create random number between 0 and 100
                var numberToGuess = new Random().Next(101);
                Console.WriteLine(numberToGuess);

                // set a variable called guessLoop to -1
                var guessLoop = -1;

                // As long as guessLoop does not equal numberChoice, loop will continue
                while (guessLoop != numberToGuess)
                {
                    // Ask the user for their guess
                    Console.Write("Enter a number: ");

                    // Read user input
                    var userGuess = Console.ReadLine();

                    if (int.TryParse(userGuess, out guessLoop))
                    {
                        // If host choice is the same as user choice
                        if (int.Parse(userGuess) == numberToGuess)
                        {
                            // Congratulate winner message
                            Console.WriteLine("Congratulations, you have guessed the right number.");

                            // Ask the user if they want to play again
                            Console.Write("Do you want to play again? Type y for Yes: ");
                            var playAgain = Console.ReadLine();

                            // If user decides to play again, start a new game
                            if (playAgain == "y")
                            {
                                newGame();
                            }
                            // Else, thank the player for playing and close
                            else
                            {
                                Console.WriteLine("Thank you for playing this Guessing Game of Doom.");

                                break;
                            }
                        }
                        // If host choice is less than user choice and user choice is less than 100
                        else if (numberToGuess < int.Parse(userGuess) && int.Parse(userGuess) < 100)
                        {
                            Console.WriteLine("The number you have guessed is too high.");
                            Console.Write("Try again. ");

                        }
                        // If host choice is greater than user choice and user choice is less than 100
                        else if (numberToGuess > int.Parse(userGuess) && int.Parse(userGuess) < 100)
                        {
                            Console.WriteLine("The number you have guessed is too low.");
                            Console.Write("Try again. ");
                        }
                        // If there is an invalid entry repeat, the while loop prompt
                        else
                        {
                            Console.WriteLine("Not a valid entry, try again. ");
                        }
                    }
                }
            }
        }
    }
}
