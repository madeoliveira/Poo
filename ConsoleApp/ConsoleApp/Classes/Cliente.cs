﻿using System;
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
        public static string Teste;

        public string Nome;
        public string Telefone;
        public string CPF;

        
    public void Gravar()
        {
            var clientes = Cliente.LerClientes();
            clientes.Add(this);
            if (File.Exists(caminhoBaseClientes()))
            {
                StreamWriter r = new StreamWriter(caminhoBaseClientes());
               
                r.WriteLine("nome;telefone;cpf;");
                foreach (Cliente c in clientes)
                {
                    var linha = c.Nome + ";" + c.Telefone + ";" + c.CPF + ";";
                    r.WriteLine(linha);
                }
                r.Close();
            }
        }

        public static string caminhoBaseClientes()
        {
            return ConfigurationManager.AppSettings["baseDosClientes"];
        }
        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();

            if (File.Exists(caminhoBaseClientes()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBaseClientes()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var clienteArquivo = linha.Split(';');

                        var cliente = new Cliente {
                            Nome = clienteArquivo[0], 
                            Telefone = clienteArquivo[1], 
                            CPF = clienteArquivo[2]
                        };
                        clientes.Add(cliente);
                    }

                }
            }
            return clientes;
        }
       
    }
}
