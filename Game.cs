using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Queuas
{
    class Game
    {

        //Added a read-only property 'MaxPlayers' of type 'int' to retrieve the maximum number of players.
        public int MaxPlayers { get; }

        //Added a 'CurrentPlayers' property with get and set accessors.
        public int CurrentPlayers { get; set; }

        //Added constructor to initialize MaxPlayers and CurrentPlayers in the Game class.
        public Game(int maxP, int currentP)
        {
            MaxPlayers = maxP;
            CurrentPlayers = currentP;
        }

        //Implement KickPlayer() method to decrement the CurrentPlayers count
        public void KickPlayer()
        {
            CurrentPlayers--;
        }

        //Added a method to check and dequeue players from a queue, incrementing the current player count if within the maximum player limit.
        public void CheckQueue(Queue<Player> playerQueue)
        {
            if (CurrentPlayers < MaxPlayers)
            {
                if (playerQueue.Count > 0)
                {
                    playerQueue.Dequeue();
                    CurrentPlayers++;
                }
                else
                {
                    Console.WriteLine("No players in the queue!");
                }
            }
        }

    }
}
