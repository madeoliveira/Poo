using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
     public  class Cliente
    {
        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }

        public Cliente()
        {

        }
        //public static string Teste;

        public string Nome;
        public string Telefone;
        public string CPF;

        
    public void Gravar()
        {
            var clientes = Cliente.LerClientes();
            clientes.Add(this);



            if (File.Exists(DiretorioClientes()))
            {
                StreamWriter r = new StreamWriter(DiretorioClientes());
               
                r.WriteLine("nome;telefone;cpf;");
                foreach (Cliente c in clientes)
                {
                    var linha = c.Nome + ";" + c.Telefone + ";" + c.CPF + ";";
                    r.WriteLine(linha);
                }
                r.Close();
            }
        }

        public static string DiretorioClientes()
        {
            return ConfigurationManager.AppSettings["DiretorioDBClientes"];
        }

        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();
            string arquivoClente = DiretorioClientes() + "clientes.txt";
            
            if (File.Exists(arquivoClente))
            {
               
                using (StreamReader arquivo = File.OpenText(arquivoClente))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1)
                            while (i>=1)
                            {
                                 var clienteArquivo = linha.Split(';');

                            var cliente = new Cliente
                            {
                                Nome = clienteArquivo[0],
                                Telefone = clienteArquivo[1],
                                CPF = clienteArquivo[2]
                            };
                                clientes.Add(cliente);
                            }
                        
                           
                        
                       
                    }

                }
            }
            return clientes;
        }
       
    }
}
