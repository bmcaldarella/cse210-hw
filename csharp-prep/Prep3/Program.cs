using System;

class Program {
    static void Main(string[] args) {
        Random random = new Random();
        bool playAgain = true;

        while (playAgain) {
            int magicNumber = random.Next(1, 101);
            int guessCount = 0;
            bool guessedCorrectly = false;

            Console.WriteLine("Welcome to the Guess My Number game!");
            Console.WriteLine("I have picked a number between 1 and 100. Try to guess it!");

            while (!guessedCorrectly) {
                Console.Write("Enter your guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber) {
                    Console.WriteLine("Higher");
                } else if (guess > magicNumber) {
                    Console.WriteLine("Lower");
                } else {
                    Console.WriteLine("You guessed it!");
                    guessedCorrectly = true;
                }
            }

            Console.WriteLine($"It took you {guessCount} guesses to find the magic number.");
            Console.Write("Do you want to play again? (yes/no): ");
            string playAgainResponse = Console.ReadLine().ToLower();

            if (playAgainResponse != "yes") {
                playAgain = false;
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}
