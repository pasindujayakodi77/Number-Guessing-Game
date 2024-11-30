using System;

class NumberGuessingGame
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("I'm thinking of a number between 1 and 100.");
        Console.WriteLine("Can you guess what it is?");
        
        // Random number generator
        Random random = new Random();
        int numberToGuess = random.Next(1, 101); // Number between 1 and 100
        int numberOfTries = 0;
        int userGuess = 0;
        
        // Game loop
        while (userGuess != numberToGuess)
        {
            Console.Write("Enter your guess: ");
            string userInput = Console.ReadLine();
            
            // Validate user input
            if (int.TryParse(userInput, out userGuess))
            {
                numberOfTries++;
                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You've guessed the number {numberToGuess} in {numberOfTries} tries!");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
        
        // End of game
        Console.WriteLine("Thank you for playing! Press any key to exit.");
        Console.ReadKey();
    }
}
