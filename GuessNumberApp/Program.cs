using System.Security.Cryptography.X509Certificates;

namespace GuessNumberApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int numGuesses;
            int userNum;
            String userReplay;

            while (playAgain)
            {
                numGuesses = 0;
                userNum = 0;
                int randomInt = random.Next(1, 101);

                Console.WriteLine("I'm thinking of a number from 1-100...");

                while (userNum != randomInt)
                {
                    userNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Your answer: {userNum}");

                    if (userNum > randomInt)
                    {
                        Console.WriteLine($"Sorry! {userNum} is too high!");
                    }
                    else if (userNum < randomInt)
                    {
                        Console.WriteLine($"Sorry! {userNum} is too low!");
                    }
                    numGuesses++;
                }
                Console.WriteLine("CONGRATULATIONS! YOU GOT IT!");
                Console.WriteLine($"ANSWER: {randomInt}");
                Console.WriteLine($"It only took you {numGuesses} tries!");
                Console.WriteLine("Play again? (Y/N)");
                userReplay = Console.ReadLine();
                userReplay = userReplay.ToUpper();
                if (userReplay == "Y")
                {
                    playAgain = true;
                } else if (userReplay == "N")
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing! See you next time!");

            Console.ReadKey();
        }
    }
}
