using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Rock, Paper, Scissors Game");
        Console.Write("Enter your choice (rock, paper, scissors): ");
        string playerChoice = Console.ReadLine().ToLower();

        string[] choices = { "rock", "paper", "scissors" };
        Random random = new Random();//this line written because we need to generate a random number
        int computerChoiceIndex = random.Next(choices.Length);
        string computerChoice = choices[computerChoiceIndex];

        Console.WriteLine("Computer's choice: " + computerChoice);

        if (playerChoice == computerChoice)
        {
            Console.WriteLine("It's a tie!");
        }
        else if ((playerChoice == "rock" && computerChoice == "scissors") ||
                 (playerChoice == "paper" && computerChoice == "rock") ||
                 (playerChoice == "scissors" && computerChoice == "paper"))  // Added missing condition
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("You lose!");
        }
    }
}
