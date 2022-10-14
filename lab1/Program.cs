using System;

namespace lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GameAccount Player1 = new GameAccount("Angelina", 1000);
            GameAccount Player2 = new GameAccount("Elizaveta", 1000);
            GameAccount Player3 = new GameAccount("Agata", 1000);
            Player1.WinGame(Player2, 100);
            Player1.WinGame(Player3, 200);
            Player3.LoseGame(Player2, 1000);
            Player1.GetStats();
            Console.WriteLine("\n");
            Player2.GetStats();
            Console.WriteLine("\n");
            Player3.GetStats();

        }
    }
}