using System;

namespace Tipos5
{
    class Game
    {
        protected Game(int i)
        {
            Console.WriteLine("Game initialization: " + i);
        }
    }

    class BoardGame : Game
    {
        protected BoardGame(int i) : base(i)
        {
            Console.WriteLine("BoardGame initialization");
        }
    }

    class Chess : BoardGame
    {
        public Chess() : base(11)
        {
            Console.WriteLine("Chess initialization");
        }
    }
    class Program
    {
        static void Main()
        {
            new Chess();
        }
    }
}