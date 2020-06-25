using ConsoleApp.Arquivos;
using ConsoleApp.Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp.Tela
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;

        public static void Criar()
        {
            while (true)
            {
                string mensagem = "\n\nOlá, bem vindo ao programa\n" +
                    "\n" +
                    "\n  Digite uma das opções: " +
                    "\n    0 - Sair do progrma" +
                    "\n    1 - Para ler arquivo" +
                    "\n    2 - Para executar a Tabuada" +
                    "\n    3 - Calcular média";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());
                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("++++++++++++Opção Ler arquivos+++++++++++++++");
                    Arquivo.Ler(1);
                    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++\n");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("=========================Opção Tabuada=====================");
                    Console.WriteLine("Gigite o número que deseja");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                    Console.WriteLine("\n ============================================\n");
                }
                else if(valor == CALCULO_MEDIA)
                {
                    Media.Aluno();
                    Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++");
                }
            
            }
        }
    }
}
