using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class PokemonData
    {
        public Pokemon[] PokemonList { get; set; }

        // Learning purpose.
        // Constructor uses the same name as the class
        public PokemonData()
        {
            PokemonList = new Pokemon[5];

            // Code Learning: This is the written out what it means way.
            // Other instances below are the shortcut quicker way = object initialization.
            Pokemon bulbasaur = new Pokemon();
            bulbasaur.Number = 1;
            bulbasaur.Name = "Bulbasaur";
            bulbasaur.Type1 = "Grass";
            bulbasaur.Type2 = "Poison";

            Pokemon charmander = new Pokemon()
            {
                Number = 4,
                Name = "Charmander",
                Type1 = "Fire",
                Type2 = "",
            };

            Pokemon squirtle = new Pokemon()
            {
                Number = 7,
                Name = "Squirtle",
                Type1 = "Water",
                Type2 = "",
            };

            Pokemon pikachu = new Pokemon()
            {
                Number = 25,
                Name = "Pikachu",
                Type1 = "Electric",
                Type2 = "",
            };

            Pokemon eevee = new Pokemon()
            {
                Number = 133,
                Name = "Eevee",
                Type1 = "Normal",
                Type2 = "",
            };

            PokemonList[0] = bulbasaur;
            PokemonList[1] = charmander;
            PokemonList[2] = squirtle;
            PokemonList[3] = pikachu;
            PokemonList[4] = eevee;

        }

    }
}
