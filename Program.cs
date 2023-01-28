using System;
using System.Collections.Generic;
using MathGame;

namespace MathGame
{
    class Program
    {
        public static string name = Helpers.GetName();

        public static void Main(string[] args)
        {
            var menu = new Menu();
            
            var date = DateTime.UtcNow;

            var games = new List<string>();
            
            menu.ShowMenu(name, true);
        }
    }
}
