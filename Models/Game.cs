using System;

namespace MathGame.Models
{
    class Game
    {
        //private int _score;

        //public int Score
        //{
        //    get { return _score; }
        //    set { _score = value; }
        //}
        internal int Score { get; set; }

        internal DateTime Date { get; set; }

        internal GameType gameType { get; set; }
    }

    internal enum GameType
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    };
}
