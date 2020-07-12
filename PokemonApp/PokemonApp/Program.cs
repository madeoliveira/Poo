using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int resp = 100;
            while (resp != 0)
            {
                resp = Menu();
                if(resp == 1)
                {
                    pokedex.ListarPokemons();
                }
                if (resp == 2)
                {
                    pokedex.ListarPokemons();
                    Console.WriteLine("Digite o código Pokémon");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                  
                    PokemonPlus pPlayer = pokedex.Pokemons[codigo];
                    Random r = new Random();
                    codigo = r.Next(0, pokedex.Pokemons.Count);
                    PokemonPlus pPC = pokedex.Pokemons[codigo];



                    if (pPlayer.Poder >= pPC.Poder)
                    {

                        Console.WriteLine("Seu Pokémon "+ pPlayer.Nome +" poder "+pPlayer.Poder+ " VS " + pPC.Nome +" Poder"+pPC.Poder
                            +".\n  Parabéns!!! Você ganhou ");
                        
                    }
                    else
                    {
                        Console.WriteLine("Seu Pokémon " + pPlayer.Nome + " poder "+pPlayer.Poder+" VS " + pPC.Nome+" Poder " +pPC.Poder+ ".\n Que pena!!! Você perdeu");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
           
        }
        static int Menu()
        {
            Console.WriteLine("Pokémon - Jogo de batalha ");
            Console.WriteLine("  0 - Sair da Pokédex");
            Console.WriteLine("  1 - Listar todos os Pokémon da Pokédex");
            Console.WriteLine("  2 - Batalhar");
            Console.Write("O que deseja fazer: ");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }
    }
}
