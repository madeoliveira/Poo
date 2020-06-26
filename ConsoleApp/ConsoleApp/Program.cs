using ConsoleApp.Arquivos;
using ConsoleApp.Classes;
using ConsoleApp.Funcoes;
using ConsoleApp.Tela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu.Criar();
            Cliente.Teste = "sss";

            var cliente = new Cliente();
            cliente.Nome = "Marcio";
            cliente.Telefone ="215152151";
            cliente.CPF = "264561555555";
            cliente.Gravar();

            var clientes = Cliente.LerClientes();
            foreach (Cliente c in clientes)
            {
                Console.WriteLine(c.Nome);
                Console.WriteLine(c.Telefone);
                Console.WriteLine(c.CPF);
                Console.WriteLine("++++++++++++++++++++++++++++++");
            }
            Console.ReadLine();
        

        }
    }
}
