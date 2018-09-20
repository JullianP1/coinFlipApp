using System;

namespace coinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;
            string userGuess;
            string coinDescription = "Tails"
            Random rng = new Random();

            //queary the user
            Console.WriteLine("Guess! Heads (H) or Tails (T)");
            userGuess = Console.ReadLine();

            //generat random number
            coin = rng.Next(0,2);

            if (coin == 1) {
                coinDescription = "Heads";
            }
            
            if (coin == 0 && userGuess == "T" || coin == 1 && userGuess == "H") {
                Console.WriteLine("The coin flip was {0}, you win!", coinDescription);
            } else {
                Console.WriteLine("The coin flip was {0}, you lost!", coinDescription);
            }
            Console.ReadLine();
        }
    }
}
