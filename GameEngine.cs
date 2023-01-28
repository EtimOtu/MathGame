using MathGame.Models;
using System;

namespace MathGame
{
    internal class GameEngine
    {
        
        internal void AdditionGame(string message)
        {
            var menu = new Menu();
            //create new random item
            var random = new Random();
            //getting firstNumber and secondNumber from 1 to 9
            int firstNumber;
            int secondNumber;
            int score = 0;

            //For loop to determine how many times to play
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                
                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine($"Correct! {firstNumber} + {secondNumber} equals {result}. Press Any key to Progress");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Incorrect! {firstNumber} + {secondNumber} does not equal {result}. Press Any key to Progress");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Game Over! Your Final score is {score}");
                    if (score == 5) Console.WriteLine($"Well done! You got a perfect {score}/5");
                }
            }

            Helpers.AddToHistory(score, GameType.Addition);


            score = 0;
            Console.WriteLine("Would you like to play again? (Y/N) or 1 for yes or 0 for no");
            var answer = Console.ReadLine();
            
            bool validInput = false;
            while(string.IsNullOrEmpty(answer) || !validInput)
            {
                switch (answer.Substring(0, 1).Trim().ToLower())
                {
                    case "y":
                    case "1":
                        validInput = true;
                        AdditionGame(null);
                        break;
                    case "n":
                    case "0":
                        validInput = true;
                        Console.Clear();
                        menu.ShowMenu(Program.name, false);
                        break;
                    default:
                        Console.WriteLine("Invalid Response. Try again.");
                        answer = Console.ReadLine();
                        break;
                }
            }
        }

        internal void SubtractionGame(string message)
        {
            var menu = new Menu();
            // create new random variable
            var random = new Random();

            int score = 0;
            int firstNumber = random.Next(1, 9);
            int secondNumber = random.Next(1, 9);

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                // get random values
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine($"Correct! {firstNumber} - {secondNumber} equals {result}. Press Any key to Progress");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Incorrect! {firstNumber} - {secondNumber} does not equal {result}. Press Any key to Progress");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Game Over! Your Final score is {score}");
                    if (score == 5) Console.WriteLine($"Well done! You got a perfect {score}/5");
                }
            }

            Helpers.AddToHistory(score, GameType.Subtraction);
            score = 0;
            Console.WriteLine("Would you like to play again? (Y/N or 1/0)");
            var answer = Console.ReadLine();
            bool validInput = false;

            while(string.IsNullOrEmpty(answer) || !validInput)
            {
                switch (answer.Substring(0, 1).Trim().ToLower())
                {
                    case "y":
                    case "1":
                        validInput = true;
                        SubtractionGame(null);
                        break;
                    case "n":
                    case "0":
                        validInput = true;
                        Console.Clear();
                        menu.ShowMenu(Program.name, false);
                        break;
                    default:
                        Console.WriteLine("Invalid response");
                        answer = Console.ReadLine();
                        break;
                }
            }
        }

        internal void MultiplicationGame(string message)
        {
            var menu = new Menu();
            //var  create random new variable
            var random = new Random();

            int firstNumber;
            int secondNumber;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 12);
                secondNumber = random.Next(1, 12);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine($"Correct! {firstNumber} * {secondNumber} equals {result}. Press Any key to Progress");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Incorrect! {firstNumber} * {secondNumber} does not equal {result}. Press Any key to Progress");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Game Over! Your Final score is {score}");
                    if (score == 5) Console.WriteLine($"Well done! You got a perfect {score}/5");
                }
            }

            Helpers.AddToHistory(score, GameType.Multiplication);
            score = 0;
            Console.WriteLine("Would you live to play again? (Yes/No or 1/0)");
            var answer = Console.ReadLine();
            bool validInput = false;
            while(string.IsNullOrEmpty(answer) || !validInput)
            {
                switch (answer.Substring(0, 1).Trim().ToLower())
                {
                    case "y":
                    case "1":
                        validInput = true;
                        MultiplicationGame(null);
                        break;
                    case "n":
                    case "0":
                        validInput = true;
                        Console.Clear();
                        menu.ShowMenu(Program.name, false);
                        break;
                    default:
                        Console.WriteLine("Invalid Response");
                        answer = Console.ReadLine();
                        break;
                }
            }
        }

        internal void DivisionGame(string message)
        {
            var menu = new Menu();
            Helpers.GetDivisionNumbers();

            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine($"Correct! {firstNumber} / {secondNumber} equals {result}. Press Any key to Progress.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Incorrect! {firstNumber} / {secondNumber} does not equal {result}. Press Any key to Progress.");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Game Over! Your Final score is {score}");
                    if (score == 5) Console.WriteLine($"Well done! You got a perfect {score}/5");
                }
            }

            Helpers.AddToHistory(score, GameType.Division);
            score = 0;
            Console.WriteLine("Would you live to play again? (Yes/No or 1/0)");
            var answer = Console.ReadLine();

            bool validInput = false;
            while (string.IsNullOrEmpty(answer) || !validInput)
            {
                switch (answer.Substring(0, 1).Trim().ToLower())
                {
                    case "y":
                    case "1":
                        validInput = true;
                        DivisionGame(null);
                        break;
                    case "n":
                    case "0":
                        validInput = true;
                        Console.Clear();
                        menu.ShowMenu(Program.name, false);
                        break;
                    default:
                        Console.WriteLine("Invalid Response");
                        answer = Console.ReadLine();
                        break;
                }
            }
        }
    }
}
