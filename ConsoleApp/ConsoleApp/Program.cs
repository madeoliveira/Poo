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
            // Menu.Criar();

            Console.WriteLine("===================== Usuarios =========");
            Usuario u = new Usuario();
            u.Nome = "Sirlei Franco";
            u.Telefone = "44444444";
            u.CPF = "777777777777";
            u.Gravar();

            foreach (Usuario us in Usuario.LerUsuarios())
            {
                Console.WriteLine(us.Nome);
                Console.WriteLine(us.Telefone);
                Console.WriteLine(us.CPF);
                Console.WriteLine("==============================");
            }

            Console.WriteLine("============= Clientes =================");
            Cliente c = new Cliente();
            c.Nome = "Sirlei Franco";
            c.Telefone = "44444444";
            c.CPF = "777777777777";
            c.Gravar();
            foreach (Cliente cs in Cliente.LerClientes())
            {
                Console.WriteLine(cs.Nome);
                Console.WriteLine(cs.Telefone);
                Console.WriteLine(cs.CPF);
                Console.WriteLine("==============================");
            }

        }
    }
}
