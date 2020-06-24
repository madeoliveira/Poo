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
                    pokedex.ListarPokemon();
                }
                Console.ReadKey();
                Console.Clear();
            }
           
        }
        static int Menu()
        {
            Console.WriteLine("Pokedex");
            Console.WriteLine("  0  - Sair da Pokedex");
            Console.WriteLine("  1 - Listar todos os Pokemon");
            Console.Write("O que deseja fazer: ");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }
    }
}
