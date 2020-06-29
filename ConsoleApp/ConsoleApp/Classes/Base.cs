using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
     public class Base:IPessoa
    {
        public Base()
        {

        }
        public Base(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }
        public string Nome;
        public string Telefone;
        public string CPF;

        
        public virtual void Gravar()
        {
            var dados = this.Ler();
            
            dados.Add(this);
           
                StreamWriter r = new StreamWriter(Diretorio());
                r.WriteLine("nome;telefone;cpf;");
                foreach (Base b in dados)
                {
                    var linha = b.Nome + ";" + b.Telefone + ";" + b.CPF + ";";
                    r.WriteLine(linha);

                }
                r.Close();
            



        }




        public List<Base> Ler()
        {
            var dados = new List<Base>();
            if (File.Exists(Diretorio()))
            {
                using (StreamReader arquivo = File.OpenText(Diretorio()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var baseArquivo = linha.Split(';');

                        var cliente = new Base(baseArquivo[0], baseArquivo[1], baseArquivo[2]);
                        dados.Add(cliente);
                    }
                }
            }
            return dados;

        }


        private string Diretorio()
        {
           return ConfigurationManager.AppSettings["DiretorioDB"]+this.GetType().Name+".txt";
        }
    }
}
