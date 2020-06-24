using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon("Bulbasaouro", "Bulbasauro é um Pokemon tipo planta ");
            pokemon.ExibirDadosPokemon(true);
            Console.ReadKey();
        }
    }
}
