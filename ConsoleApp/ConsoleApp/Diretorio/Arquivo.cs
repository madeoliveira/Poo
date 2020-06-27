using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Arquivos
{
    class Arquivo
    {
        public static string DiretorioArquivo()
        {
            return ConfigurationManager.AppSettings["DiretorioArquivos"];
        }
        public static void Ler(int numeroArquivo)
        {
            string arquivoComCaminho = DiretorioArquivo() +"arq" + numeroArquivo + ".txt";
            Console.WriteLine("============ Lendo arquivo ===========\n" +arquivoComCaminho+ "\n======================" );
                if (File.Exists(arquivoComCaminho))
                {
                using(StreamReader arquivo = File.OpenText(arquivoComCaminho))
                    {
                    string linha;
                    while((linha = arquivo.ReadLine()) != null)
                        {
                        Console.WriteLine(linha);
                         }

                 }
            }
            string arquivoComCaminho2 = DiretorioArquivo() + "arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                Ler(numeroArquivo + 1);
            }
        }
       
    }
   
}
