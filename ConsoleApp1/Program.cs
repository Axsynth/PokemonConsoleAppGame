using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerName = new Player();

            Console.WriteLine("You're about to embark on a new adventure. Please enter your name.");

            var nickName = Console.ReadLine();

            Console.WriteLine(playerName.SetPlayerName(nickName));

            Console.WriteLine("You have a chance to be the very best, like no one ever was.\nI present to you your very own Pokemon.\n");
            Console.WriteLine("Please pick one of the following:");
            Console.WriteLine("1: Bulbasaur");
            Console.WriteLine("2: Charmander");
            Console.WriteLine("3: Squirtle");
            Console.WriteLine("4: Ooo Shiny!");
            Console.WriteLine("5: I don't need a Pokemon to be the very best.\n");

            Console.WriteLine("Please use the number 1-5 for your selection:");
            var pokemonSelection = Console.ReadLine();

            if (pokemonSelection == "1")
            {
                var pokemon1 = new PokemonData();
                Console.WriteLine("\nYou picked Bulbasaur.");
                // Want to make the content below pull PokemonData class information next. Don't know how to just yet.
                // Same with the other selection below.
                Console.WriteLine("Bulbasaur is a Grass/Poison type pokemon. You have selected the only pokemon that has dual elements.\n");
            }
            else if(pokemonSelection == "2")
            {
                Console.WriteLine("\nYou picked Charmander.");
                Console.WriteLine("Charmander is a Fire type pokemon. Charmander will evolve into one of the most fearsome Pokemon. Congratulations!\n");
            }
            else if(pokemonSelection == "3")
            {
                Console.WriteLine("\nYou picked Squirtle.");
                Console.WriteLine("Squirtle is a Water type pokemon. Squirtle loves to have fun and cause trouble.\n");
            }
            else if(pokemonSelection == "4")
            {
                Console.WriteLine("\nYou got distracted and stretched out your hand toward something shiny. It shocked you!\n" +
                    "As you pulled your hand back, a yellow mouse jumped at your hand and bit it. You yelled loudly.\n" +
                    "It looks like you've bothered this Pikachu and now it's never going to leave you.");
                Console.WriteLine("Pikachu is an Electric type pokemon.\n");
            }
            else if (pokemonSelection == "5")
            {
                Console.WriteLine("\nIt's dangerous to go alone! I'll give you Eevee.");
                Console.WriteLine("Eevee is a Normal type pokemon.\n");
            }
            else
            {
                Console.WriteLine("\nYou decided not to select any of the options given.\n" +
                    "You walked back home, climbed into your bed, and went back to sleep.\n");
                Console.WriteLine("~ GAME OVER ~\n");
            }
        }
    }
}
