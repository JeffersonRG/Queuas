using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queuas
{
    internal class Player
    {
        //Added properties for Health and GamerTag in the Player class, with a constructor to initialize these properties using provided parameters.
        public int Health { get; set; }

        public string GamerTag { get; }

        public Player(int healthParam, string nameParam)
        {
            Health = healthParam;
            GamerTag = nameParam;
        }

        //Added a method to join a game, incrementing the player count for the game if there's space available; otherwise, added the player to the waiting queue.
        public void JoinGame(Game game, Queue<Player> queue)
        {
            if (game.CurrentPlayers == game.MaxPlayers)
            {
                queue.Enqueue(this);
            }
            else
            {
                Console.WriteLine("Joining Game!");
                game.CurrentPlayers++;
            }
        }
        //Implementing override for ToString() method to return the GamerTag
        public override string ToString()
        {
            return GamerTag;
        }
    }
}
