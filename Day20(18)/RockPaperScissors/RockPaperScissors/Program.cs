using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string playerName = Console.ReadLine();

            RockPaperScissorsGame game = new RockPaperScissorsGame(playerName);
            game.Play();
        }
    }
}