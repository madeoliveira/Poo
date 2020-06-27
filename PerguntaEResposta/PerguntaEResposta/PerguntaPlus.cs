using System;

namespace PerguntaEResposta
{
    public class PerguntaPlus:Pergunta
    {
        public PerguntaPlus():base()
        {
          
            this.Dica = "";
        }
        public PerguntaPlus(String texto, String resposta,String dica) : base(texto,resposta)
        {

            this.Dica = dica;
        }
        public String Dica { get; set; }

    }
}
