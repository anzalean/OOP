using System;

namespace lab1
{
    public class GameAccount
    {
                public enum Result
        {
            Win,
            Lose
        }
        public string user_name;
        public uint current_rating { get; set; }
        public uint games_count = 0;
        public GameAccount(string __user_name, uint __current_rating)
        {
            user_name = __user_name;

            if (__current_rating > 1)
            {
                current_rating = __current_rating;
            }
            else
            {
                Console.WriteLine("Rating below 1");
            }
        }

        public Game[] games = new Game[10]; 

        public void WinGame(GameAccount opponent_name, uint rating)
        {
            if (rating > 0)
            {
                Game game_for_this = new Game(this, opponent_name, rating, Result.Win);
                Game game_for_that = new Game(opponent_name, this, rating, Result.Lose);
                this.current_rating += rating;
                opponent_name.current_rating -= rating;
                if (opponent_name.current_rating < 1)
                    opponent_name.current_rating = 1;
                this.games[this.games_count] = game_for_this;
                opponent_name.games[opponent_name.games_count] = game_for_that;
                this.games_count++;
                opponent_name.games_count++;
            }
            else
            {
                Console.WriteLine("Rating for game below 0");
            }
        }

        public void LoseGame(GameAccount opponent_name, uint rating)
        {
            if(rating > 0)
            {
                Game game_for_this = new Game(this, opponent_name, rating, Result.Lose);
                Game game_for_that = new Game(opponent_name, this, rating, Result.Win);
                this.current_rating -= rating;
                if (this.current_rating < 1)
                     this.current_rating = 1;
                opponent_name.current_rating += rating;
                this.games[this.games_count] = game_for_this;
                opponent_name.games[opponent_name.games_count] = game_for_that;
                this.games_count++;
                opponent_name.games_count++;
            }
            else
            {
                Console.WriteLine("Rating for game below 0");
            }
        }

        public void GetStats()
        {
            for(int i = 0; i < this.games_count; i++)
            {
                this.games[i].ShowGame();
            }
            Console.WriteLine("\nCurrent rating:" + this.current_rating);
        }

        
    }
}