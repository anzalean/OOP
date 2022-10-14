using System;

namespace lab1
{
    public class Game
    {
        public GameAccount Person1;
        public GameAccount Person2;
        public uint Rating;
        public string IDOfGame;
        public string Result;
        public Game(GameAccount __person1, GameAccount __person2, uint __rating, GameAccount.Result __result)
        {
            Person1 = __person1;
            Person2 = __person2;
            Rating = __rating;
            if (__result == GameAccount.Result.Win)
                Result = "Win";
            else
                Result = "Lose";
            Guid myuuid = Guid.NewGuid();
            IDOfGame = myuuid.ToString();
        }

        public void ShowGame()
        {
            Console.WriteLine("\n" + this.Person1.user_name + " played with " + this.Person2.user_name + " for " + this.Rating + " rating with result: " + this.Result + "\n");
            Console.WriteLine("ID of Game: " + this.IDOfGame);
        }

        
    }
}