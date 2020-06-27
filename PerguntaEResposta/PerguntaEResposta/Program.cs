using System;

namespace PerguntaEResposta
{
    class Program
    {
        static void Main(string[] args)
        {
           PerguntaPlus p= new PerguntaPlus();
            p.Texto = " Númeral de 1 a 100 ";
            p.Resposta = "16";
            p.Dica = "10 + 6 ";

            Console.WriteLine("Qual a resposta?");
            Console.WriteLine("Pergunta: " + p.Texto);
            Console.WriteLine("Dica: " + p.Dica);
            Console.WriteLine("Resposta: ");
            String resposta = Console.ReadLine();
            if (p.Resposta.ToUpper() == resposta.ToUpper())
            {
                Console.WriteLine("Parabéns!!! ");

            }
            else
            {
                Console.WriteLine("Errado!!!");
                Console.WriteLine("A resposta correta é: " + p.Resposta);

            }
            Console.ReadKey();
        }
    }
}
