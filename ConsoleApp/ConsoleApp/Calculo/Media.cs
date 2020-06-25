using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Media
    {
        public static void Aluno()
        {
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            int qtdNotas = 5;
            Console.WriteLine("Digite os " + qtdNotas + " Números Sr(a) " + nome);
            List<int> notas = new List<int>();
            int totalNotas = 0;
            for(int i=1; i <= qtdNotas; i++)
            {
                Console.WriteLine("Digite  numero " + i);
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);
            }
            int media = totalNotas / notas.Count;
            Console.WriteLine("A média do Sr(a) " + nome + " é " + media);
            Console.WriteLine("Números digitados são: \n");
            foreach(int nota in notas)
            {
                Console.WriteLine("Número: " + nota + "\n");
            }
        }

    }
}
