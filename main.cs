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

        while (guess != number)
        {
            Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
            guess = Convert.ToInt32(Console.ReadLine());

            // Another way to make it more interactive to the user if we use something like random.
            // if (guess > number){
            //   Console.WriteLine(guess + " is too high!");
            // } else if (guess < number){
            //   Console.WriteLine(guess + " is too low!");
            // }

            if (guess != number)
            {
                Console.WriteLine("Incorrect");
            }

            guesses++;
        }
        Console.WriteLine("Correct");
        Console.WriteLine("It took you " + guesses + " guesses.");
    }
}