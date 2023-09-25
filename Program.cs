// See https://aka.ms/new-console-template for more information

using Queuas;

class Program
{
    static void Main(string[] args)
    {
        //Added code to initialize a Game object with specific parameters and create a Queue for managing players waiting to join the game.
        Game myGame = new Game(50, 49);
        Queue<Player> waitingToJoinQ = new Queue<Player>();

        //Added code to create four Player objects (p1, p2, p3, and p4) with initial health values of 100 and corresponding player names.
        Player p1 = new Player(100, "MMSix");
        Player p2 = new Player(100, "xXAwesomenessXx");
        Player p3 = new Player(100, "Get Good");
        Player p4 = new Player(100, "ZombieSlaya");

        //Added code to have players p1, p2, p3, and p4 join the game "myGame" using the "waitingToJoinQ" queue.
        p1.JoinGame(myGame, waitingToJoinQ);
        p2.JoinGame(myGame, waitingToJoinQ);
        p3.JoinGame(myGame, waitingToJoinQ);
        p4.JoinGame(myGame, waitingToJoinQ);

        //Added code to print the list of players currently waiting to join the queue to the console, preceded by the message "Players in da Q:".
        Console.WriteLine("Players in da Q:");
        foreach (Player player in waitingToJoinQ)
        {
            Console.WriteLine(player);
        }

        //Implemented player kicking functionality and checked the waiting queue for player joins in the 'myGame' module
        myGame.KickPlayer();
        myGame.CheckQueue(waitingToJoinQ);

        //Added code to display players currently waiting to join the queue using Console.WriteLine.
        Console.WriteLine("\nPlayers in da Q:");
        foreach (Player player in waitingToJoinQ)
        {
            Console.WriteLine(player);
        }
    }
}