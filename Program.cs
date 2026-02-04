using System;

namespace GuessingGame

{    class Program
    {
        static void Main(string[] args)
        {
            int target = 17;
            int chances = 3;
            int guess;
            bool win = false;
            string input;


            Console.WriteLine($"Guess the number between 1 and 50");

            for (int i = 1; i <= chances; i++)
            {
                Console.Write($"\nAttempt {i}: Enter your guess: ");

                input = Console.ReadLine();
            
                if (int.TryParse(input, out guess))
                {
                    if (guess == target)
                    {
                        win = true;
                        break;
                    }
                    else if (guess < target)
                    {
                        Console.WriteLine($"The number is higher than {guess},try again");
                    }
                    else
                    {
                        Console.WriteLine($"The number is lower than {guess}, try again:");
                    }
                }
                
            }

            if (win)
            {
                Console.WriteLine("\nCongrats, you guessed it!");
            }
            else
            {
                Console.WriteLine($"\n The game is over, the number was {target}.");
            }
        }
    }
}
