using System;

namespace coinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;
            string userGuess;
            Random rng = new Random();

            //queary the user
            Console.WriteLine("Guess!");
            userGuess = Console.ReadLine();

            //generat random number
            coin = rng.Next(0,2);

            if (coin == 0 && userGuess == "T" || coin == 0 && userGuess == "t") {
                Console.WriteLine("The coin flip was tails, you win!");
            } else if (coin == 1 && userGuess == "F" || coin == 1 && userGuess == "F") {
                Console.WriteLine("The coin flip was heads, you win!");
            }
        }
    }
}
