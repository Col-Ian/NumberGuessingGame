/*
  Number Guessing Game
  Created by Ian Collins
  Number inteded to find is 42
*/

using System;

class Program
{
    public static void Main(string[] args)
    {
        int min = 1;
        int max = 100;
        // Initialize the value.
        int guess = 0;
        // Number given to find.
        int number = 42;
        // Count the number of guesses.
        int guesses = 0;
        // Validate an int is entered.
        bool inputValidation;
        // Initialize the value to use for TryParse()
        string isItInt = null;

        while (guess != number)
        {
            Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
            isItInt = Console.ReadLine();

            // Validate it as an int
            inputValidation = int.TryParse(isItInt, out guess);
            guess = Convert.ToInt32(guess);
            if (inputValidation == false || guess < min || guess > max)
            {
                Console.WriteLine("Not a valid number.");
            }
            else if (guess != number)
            {
                Console.WriteLine("Incorrect");
            }
            // Another way to make it more interactive to the user if we use something like random.
            // if (guess > number){
            //   Console.WriteLine(guess + " is too high!");
            // } else if (guess < number){
            //   Console.WriteLine(guess + " is too low!");
            // }



            guesses++;
        }
        Console.WriteLine("Correct");
        Console.WriteLine("It took you " + guesses + " guesses.");
    }
}