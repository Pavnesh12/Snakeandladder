using System;

namespace snakeandladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Snake and ladder game");
          Snakegame game = new Snakegame();
            game.diceroll();
        }
    }
}
