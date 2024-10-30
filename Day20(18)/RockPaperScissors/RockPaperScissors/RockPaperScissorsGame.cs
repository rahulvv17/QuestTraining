using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class RockPaperScissorsGame
    {
        private Player player;
        private Computer computer;
        private Random rand;
        private Dictionary<int, string> options;

        public RockPaperScissorsGame(string playerName)
        {
            player = new Player(playerName);
            computer = new Computer();
            rand = new Random();
            options = new Dictionary<int, string>
            {
                { 1, "Paper" },
                { 2, "Rock" },
                { 3, "Scissors" }
            };
        }

        public void Play()
        {
            while (player.Score < 10 && computer.Score < 10)
            {
                Console.WriteLine($"{player.Name}, choose 1 for Paper, 2 for Rock, or 3 for Scissors: ");
                if (!int.TryParse(Console.ReadLine(), out int playerChoice) || playerChoice < 1 || playerChoice > 3)
                {
                    Console.WriteLine("Invalid choice, please try again.");
                    continue;
                }

                int computerChoice = rand.Next(1, 4);

                Console.WriteLine($"{player.Name} chose: {options[playerChoice]}");
                Console.WriteLine($"Computer chose: {options[computerChoice]}");

                DetermineWinner(playerChoice, computerChoice);

                Console.WriteLine($"{player.Name}'s score: {player.Score}");
                Console.WriteLine($"Computer's score: {computer.Score}");
                Console.WriteLine();
            }

            if (player.Score == 10)
            {
                Console.WriteLine($"Congratulations {player.Name}, you won!");
            }
            else
            {
                Console.WriteLine("Computer wins the game!");
            }
        }

        private void DetermineWinner(int playerChoice, int computerChoice)
        {
            if (playerChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((playerChoice == 1 && computerChoice == 2) || // Paper beats Rock
                     (playerChoice == 2 && computerChoice == 3) || // Rock beats Scissors
                     (playerChoice == 3 && computerChoice == 1))   // Scissors beats Paper
            {
                Console.WriteLine($"{player.Name} wins this round!");
                player.Score++;
            }
            else
            {
                Console.WriteLine("Computer wins this round!");
                computer.Score++;
            }
        }
    }
}