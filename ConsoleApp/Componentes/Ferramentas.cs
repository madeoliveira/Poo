using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Componentes
{
    public class Ferramentas
    {
        internal string MetodoIterno()
        {
            return "Este método só pode ser acessado deste assembley";
        }
        public string MetodoPublico()
        {
            return "Este método para todos";
        }
        public bool ValidarCPF(string cpf)
        {
            return true;
        }
    }
}
