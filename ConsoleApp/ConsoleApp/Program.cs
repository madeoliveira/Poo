using Componentes;
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

           // Ferramentas f = new Ferramentas();
           //bool c = f.ValidarCPF("100,122.586-56");
           // // Menu.Criar();

            Console.WriteLine("===================== Usuarios =========");
            Cliente u = new Cliente();
            u.Nome = "Sirlei Franco";
            u.Telefone = "44444444";
            u.CPF = "777777777777";
            u.Gravar();

            foreach (Cliente us in new Cliente().Ler())
            {
                Console.WriteLine(us.Nome);
                Console.WriteLine(us.Telefone);
                Console.WriteLine(us.CPF);
                Console.WriteLine("==============================");
            }

            //Console.WriteLine("============= Clientes =================");
            //Cliente ce = new Cliente();
            //ce.Nome = "Rafael Franco";
            //ce.Telefone = "2222222";
            //ce.CPF = "999999999999";
            //ce.Gravar();

            //foreach (Cliente cs in Cliente.LerClientes())
            //{ 
            //    Console.WriteLine(cs.Nome);
            //    Console.WriteLine(cs.Telefone);
            //    Console.WriteLine(cs.CPF);
            //    Console.WriteLine("==============================");
            //}

        }
    }
}
