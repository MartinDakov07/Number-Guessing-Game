using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int min = 1;
            int max = 100;
            bool playAgain = true;
            int guess;
            int guesses;
            int num;
            string response;
            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                num = random.Next(min, max + 1);
                Console.WriteLine($"Guess the number between {min} - {max}");
                while (guess != num)
                {                    
                    guess = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Guess {guess}");

                    if(guess > num)
                    {
                        Console.WriteLine($"{guess} it too high!");
                    }
                    else if(guess < num)
                    {
                        Console.WriteLine($"{guess} is too low!");
                    }
                    guesses++;
                }
                Console.WriteLine();
                Console.WriteLine($"Number: {guess}");
                Console.WriteLine();
                Console.WriteLine("Congratulations! You guessed the number!");
                Console.WriteLine();
                Console.WriteLine("YOU WIN");
                Console.WriteLine();
                Console.WriteLine($"Guesses:{guesses}");
                Console.WriteLine();
                Console.WriteLine("Do you want to play again? (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();
                if(response == "Y")
                {
                    playAgain = true;
                }
                else if(response == "N")
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thank you for playing this simple game!");
        }
    }
}
