using System;

namespace MathGame
{
    internal class Menu
    {
        GameEngine engine = new GameEngine();
        internal void ShowMenu(string name, bool firstTime)
        {
            Console.Clear();
            if (firstTime)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"Hello {name.ToUpper()}. It's {DateTime.UtcNow.DayOfWeek}. Welcome to your very own math game!");
                Console.WriteLine("Press any key to show menu");
                Console.ReadLine();
            }
            Console.Clear();

            bool gameIsOn = true;
            do
            {
                Console.WriteLine($@"What game would you like to play today? Choose from the options below:
V - View Previous Scores
A - Addition
B - Subtraction
C - Multiplication
D - Division
Q - Quit the program");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                var gameSelected = Console.ReadLine();
                bool validInput = false;

                while (string.IsNullOrEmpty(gameSelected) || !validInput)
                {
                    //Decide which application to open
                    switch (gameSelected.Trim().ToLower())
                    {
                        case "v":
                            validInput = true;
                            Helpers.GetGames();
                            break;
                        case "a":
                            validInput = true;
                            engine.AdditionGame("Addition game");
                            break;
                        case "b":
                            validInput = true;
                            engine.SubtractionGame("Subtraction game");
                            break;
                        case "c":
                            validInput = true;
                            engine.MultiplicationGame("Multiplication game");
                            break;
                        case "d":
                            validInput = true;
                            engine.DivisionGame("Division game");
                            break;
                        case "q":
                            validInput = true;
                            Helpers.QuitGame();
                            gameIsOn = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Input. Please Try Again.");
                            gameSelected = Console.ReadLine();
                            break;
                    }
                }
                
                
            } while (gameIsOn);

            #region if/else if statements
            /*if (gameSelected.Trim().ToLower() == "a")
            {
                // Access Addition Game
                AdditionGame("Addition game selected");
            }
            else if (gameSelected.Trim().ToLower() == "b")
            {
                // Access Subtraction Game
                SubtractionGame("Subtraction game selected");
            }
            else if (gameSelected.Trim().ToLower() == "c")
            {
                // Access Multiplication Game
                MultiplicationGame("Multiplication game selected");
            }
            else if (gameSelected.Trim().ToLower() == "d")
            {
                // Access Division Game
                DivisionGame("Division game selected");
            }
            else if (gameSelected.Trim().ToLower() == "q")
            {
                Console.WriteLine("Thanks for playing!");
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again.");
                Console.ReadLine();
                Console.Clear();
                ShowHome();
            }*/
            #endregion
        }
    }
}
