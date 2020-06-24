using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerguntaEResposta
{
    class Pergunta
    {
        public Pergunta()
        {
            this.Texto = "";
            this.Resposta = "";

        }

        public Pergunta(String testo,String resposta)
        {
            this.Texto = texto;
            this.Resposta = resposta;

        }
        private String texto;

        public String Texto
        {
            get { return texto; }
            set { texto = value; }
        }
        public String Resposta { get; set; }
    }
}
