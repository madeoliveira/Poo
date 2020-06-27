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

        public string Nome;
        public string Telefone;
        public string CPF;

        
    public virtual void Gravar()
        {
            var cliente = Cliente.LerClientes();
           // Cliente u = new Cliente(this.Nome, this.Telefone, this.CPF);
            cliente.Add(this);
            if (File.Exists(DiretorioClientes()))
            {
                StreamWriter r = new StreamWriter(DiretorioClientes());
                r.WriteLine("nome;telefone;cpf;");
                foreach (Cliente us in cliente)
                {
                    var linha = us.Nome + ";" + us.Telefone + ";" + us.CPF + ";";
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
            if (File.Exists(DiretorioClientes()))
            {
                using (StreamReader arquivo = File.OpenText(DiretorioClientes()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var clienteArquivo = linha.Split(';');

                        var cliente = new Cliente(clienteArquivo[0], clienteArquivo[1], clienteArquivo[2]);
                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
           
        }
       
        
    }
}
