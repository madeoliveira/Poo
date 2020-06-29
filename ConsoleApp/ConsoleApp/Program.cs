using ConsoleApp.Classes;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Email.Instancia.Corpo = "Olá, teste de email com classe SINGLETON";
            Email.Instancia.Titulo = "Classe SINGLETON";
            Email.Instancia.Origem = "email@email.com.br";
            Email.Instancia.Destino = "email@email.com";

            Email.Instancia.EnviarEmail();

           //// Ferramentas f = new Ferramentas();
           ////bool c = f.ValidarCPF("100,122.586-56");
           //// // Menu.Criar();

           // Console.WriteLine("===================== Usuarios =========");
           // Usuario u = new  Usuario();
           // u.Nome = "Rafael Franco";
           // u.Telefone = "99995555444";
           // u.CPF = "43668989898989";
           // u.Gravar();

           // foreach (Base us in new Usuario().Ler())
           // {
           //     Console.WriteLine(us.Nome);
           //     Console.WriteLine(us.Telefone);
           //     Console.WriteLine(us.CPF);
           //     Console.WriteLine("==============================");
               
           // }
           // Console.ReadKey();

           // //Console.WriteLine("============= Clientes =================");
           // //Cliente ce = new Cliente();
           // //ce.Nome = "Rafael Franco";
           // //ce.Telefone = "2222222";
           // //ce.CPF = "999999999999";
           // //ce.Gravar();

           // //foreach (Cliente cs in Cliente.LerClientes())
           // //{ 
           // //    Console.WriteLine(cs.Nome);
           // //    Console.WriteLine(cs.Telefone);
           // //    Console.WriteLine(cs.CPF);
           // //    Console.WriteLine("==============================");
           // //}

        }
    }
}
