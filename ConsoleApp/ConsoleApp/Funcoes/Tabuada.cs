using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Funcoes
{
    class Tabuada
    {
        public static void Calcular (int numero)
        {
            Console.WriteLine("=====================Calculo da Tabuada" + numero + "==================");
            for (int i = 0; i <= 10 ; i++)
            {
                Console.WriteLine(numero + "X" + i + " = " + (numero * i));
            }
            Console.WriteLine("====================================");

      
        }

    }
}
