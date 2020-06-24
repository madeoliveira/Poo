using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp
{
    public class Pokemon
    {
        public Pokemon()
        {
            this.Nome = "";
            this.Descricao = "";
        }

        private String nome;

        public String Nome
        {
            get {
                return nome; 
            }
            set {
                String texto = value;
                nome = texto;
            }
        }
        private String descricao;

        public String Descricao
        {
            get { 
                return this.descricao; 
            }
            set {
                this.descricao = value; 
            }
        }

        public void ExibirDadosPokemon()
        {
            Console.WriteLine("Nome do Pokémon: " + this.Nome);
            Console.WriteLine("Descrição do Pokémon: " + this.Descricao);
        }

    }
}
