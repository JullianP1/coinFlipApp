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
            Console.WriteLine("Guess! Heads (H) or Tails (T)");
            userGuess = Console.ReadLine();

            //generat random number
            coin = rng.Next(0,2);

            if (coin == 0 && userGuess == "T" || coin == 0 && userGuess == "t") {
                Console.WriteLine("The coin flip was tails, you win!");
            } else if (coin == 1 && userGuess == "H" || coin == 1 && userGuess == "h") {
                Console.WriteLine("The coin flip was heads, you win!");
            } else {
                if (coin == 0) {
                    Console.WriteLine("The coin flip was tails, you lost!");
                } else {
                    Console.WriteLine("The coin flip was heads, you lost!");
                }
            }
            Console.ReadLine();
        }
    }
}
