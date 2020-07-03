using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializaLista();
        }
        private List<PokemonPlus> pokemons;

        public List<PokemonPlus> Pokemons
        {
            get { return pokemons; }
        }
        private void InicializaLista()
        {
            this.pokemons = new List<PokemonPlus>();
            PokemonPlus p = new PokemonPlus("Bulbasouro","Sua descrição",100);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mew", "Lendario psiquico",90);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mewtwo", "Lendario psiquico",95);
            this.pokemons.Add(p);
            p = new PokemonPlus("Giratina", "Lendario Fantasma",23);
            this.pokemons.Add(p);
            p = new PokemonPlus("Fleygon", "Pokémon dragão",100);
            this.pokemons.Add(p);
            p = new PokemonPlus("Metagross", "Pokémon de metal",70);
            this.pokemons.Add(p);
            p = new PokemonPlus("Muk", "Pokémon de metal",55);
            this.pokemons.Add(p);
            p = new PokemonPlus("Lucario", "Lutador lendario",98);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mudkip", "Pokémon água",89);
            this.pokemons.Add(p);
            p = new PokemonPlus("Paras", "Pokémon inseto",88);
            this.pokemons.Add(p);
            p = new PokemonPlus("Kyogre", "Lendario da água",23);
            this.pokemons.Add(p);



        }
        public void ListarPokemon()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                this.Pokemons[i].ExibirDadosPokemon(true);          
            }
                
        }

    }
}
