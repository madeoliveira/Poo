using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
    public class Usuario : Cliente
    {
        public Usuario(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }
        public Usuario()
        {
        }

        public override void Gravar()
        {

            var usuario = Usuario.LerUsuarios();
            Usuario u = new Usuario(this.Nome, this.Telefone, this.CPF);
            usuario.Add(u);
            if (File.Exists(DiretorioUsuarios()))
            {
                StreamWriter r = new StreamWriter(DiretorioUsuarios());
                r.WriteLine("nome;telefone;cpf;");
                foreach (Usuario us in usuario)
                {
                    var linha = us.Nome + ";" + us.Telefone + ";" + us.CPF + ";";
                    r.WriteLine(linha);

                }
                r.Close();
            }

        }
        public static string DiretorioUsuarios()
        {
            return ConfigurationManager.AppSettings["DiretorioDBUsuarios"];
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

                        var usuario = new Usuario(usuarioArquivo[0], usuarioArquivo[1], usuarioArquivo[2]);
                        usuarios.Add(usuario);
                    }
                }
            }
            return usuarios;
        }
    }


}

