using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerName = new Player();

            Console.WriteLine("You're about to embark on a new adventure. Please enter your name.\n");

            var nickName = Console.ReadLine();

            Console.WriteLine(playerName.SetPlayerName(nickName));


            /* 
                ~HOMEWORK~
                - Next Step is to have the player select their Pokemon and print out the Pokemon selected by the player.
                - Add whatever data/info you want to show.
            */
        }
    }
}
