using MathGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game> 
        { 
            
        };

        internal static string ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer must be an integer. Please try again.");
                result = Console.ReadLine();
            }
            return result;
        }

        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(1, 99);
            var secondNumber = random.Next(1, 99);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;


            return result;
        }

        internal static void GetGames()
        {
            // **A lambda function: This filters a sequence of values based on a predicate
            //var gamesToPrint = games.Where(x => x.Date > new DateTime(2023, 02, 01)).OrderByDescending(x => x.Score);

            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.gameType} Score: {game.Score}");
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.WriteLine("Press Any Key to Continue ");
            Console.ReadLine();
            Console.Clear();
        }

        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                gameType = gameType
            });
        }

        internal static string GetName()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine().Trim();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty");
                name = Console.ReadLine().Trim();
            }
            return name;
        }

        internal static void QuitGame()
        {
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(1);
        }
    }
}
