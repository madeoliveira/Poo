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

        
    public void Gravar()
        {
            if(this.GetType() == typeof(Cliente))
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
            else
            {

                var usuario = Usuario.LerUsuarios();
                Usuario u = new Usuario(this.Nome, this.Telefone, this.CPF);
                usuario.Add(u);
                if (File.Exists(DiretorioUsuarios()))
                {
                    StreamWriter r = new StreamWriter(DiretorioUsuarios());
                    r.WriteLine("nome;telefone;cpf;");
                    foreach (Usuario c in usuario)
                    {
                        var linha = c.Nome + ";" + c.Telefone + ";" + c.CPF + ";";
                        r.WriteLine(linha);

                    }
                    r.Close();
                }

            }


        }

        public static string DiretorioClientes()
        {
            return ConfigurationManager.AppSettings["DiretorioDBClientes"];
        }

        public static string DiretorioUsuarios()
        {
            return ConfigurationManager.AppSettings["DiretorioDBUsuarios"];
        }



        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();
            string arquivoClente = DiretorioClientes();
            
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
                            while (i==1)
                            {
                                 var clienteArquivo = linha.Split(';');

                            var cliente = new Cliente (clienteArquivo[0], clienteArquivo[1],clienteArquivo[2]);
                                clientes.Add(cliente);
                            }
                        
                           
                        
                       
                    }

                }
            }
            return clientes;
        }
       
        public static List<Usuario> LerUsuarios()
        {
            var usuarios = new List<Usuario>();
            if (File.Exists(DiretorioUsuarios()))
            {
                using (StreamReader arquivo = File.OpenText(DiretorioUsuarios()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var usuarioArquivo = linha.Split(';');
                        
                        var usuario = new Usuario(usuarioArquivo[0], usuarioArquivo[0], usuarioArquivo[0]);
                        usuarios.Add(usuario);
                    }
                }
            }
            return usuarios;
        }
    }
}
