using System;

namespace Players
{
    class Program
    {
        static void Main(string[] args)
        {
            var Randomize = new Random();
            var players = new[]
            {
                new Player("Per", 10, Randomize), 
                new Player("Pål", 10, Randomize), 
                new Player("Espen", 10, Randomize)
            };
            for (var round = 1; round <= 10; round++)
            {
                var playerIndex1 = Randomize.Next(players.Length);
                var playerIndex2 = (playerIndex1 + 1 + Randomize.Next(2)) % players.Length;
                var player1 = players[playerIndex1];
                var player2 = players[playerIndex2];
                player1.Play(player2);
            }

            foreach (var player in players)
            {
                player.DisplayNameAndPointValues(Randomize);
            }
        }
    }
}
