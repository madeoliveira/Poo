using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix(Console.WindowWidth, Console.WindowHeight);
            m.Loop();
        }
    }
}
