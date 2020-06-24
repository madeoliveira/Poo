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
        private List<Pokemon> pokemons;

        public List<Pokemon> Pokemons 
        {
            get { return pokemons; }
        }
        private void InicializaLista()
        {
            this.pokemons = new List<Pokemon>();
            Pokemon p = new Pokemon("Bulbasouro","Sua descrição");
            this.pokemons.Add(p);
            p = new Pokemon("Mew", "Lendario psiquico");
            this.pokemons.Add(p);
            p = new Pokemon("Mewtwo", "Lendario psiquico");
            this.pokemons.Add(p);
            p = new Pokemon("Giratina", "Lendario Fantasma");
            this.pokemons.Add(p);
            p = new Pokemon("Fleygon", "Pokemon dragão");
            this.pokemons.Add(p);
            p = new Pokemon("Metagross", "Pokemon de metal");
            this.pokemons.Add(p);
            p = new Pokemon("Muk", "Pokemon de metal");
            this.pokemons.Add(p);
            p = new Pokemon("Lucario", "Lutador lendario");
            this.pokemons.Add(p);
            p = new Pokemon("Mudkip", "Pokemon agua");
            this.pokemons.Add(p);
            p = new Pokemon("Paras", "Pokemon inseto");
            this.pokemons.Add(p);
            p = new Pokemon("Kyogre", "Lendario da agua");
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
