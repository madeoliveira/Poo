using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp
{
    public class PokemonPlus:Pokemon
    {
        public PokemonPlus() : base()
        {
            this.Poder = 0;
        }
        public PokemonPlus(String nome, String descriao, int poder) : base(nome,descriao)
        {
            this.Poder = poder;
        }
        public int Poder { get; set; }
        
        public void ExibirDadosPokemonPlus()
        {
            Console.WriteLine("Nome do Pokémon "+this.Nome);
            Console.WriteLine("Descrição do Pokémon: " + this.Descricao);
            Console.WriteLine("Poder: " + this.Poder);
        }
    }
}
