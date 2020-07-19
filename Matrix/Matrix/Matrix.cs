using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        private bool _quit;
        private int[,] _campo;
        private int _width;
        private int _height;

        private const int SPAWN_DELAY = 32;

        public Matrix(int width, int height)
        {
            _quit = false;
            _width = width;
            _height = height;
            try
            {
                _campo = new int[height, width];
            }
            catch(Exception e)
            {
                throw new Exception("O correu um erro ao tentar criar o campo de letras: " + e.Message);
            }
        }
        private void Inicializar()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Random r = new Random();
            int distdotopo = r.Next(2, 20);
            int comprimento = r.Next(2, 20);
            for (int pos = 0; pos < _width; pos++)
            {
                for (int i = 0; i < comprimento; i++)
                {
                    if (distdotopo + i < _height && pos % 2 == 0)
                    {
                        if (i < comprimento - 1)
                        {
                            _campo[distdotopo + i, pos] = 1;
                        }
                        else
                        {
                            _campo[distdotopo + i, pos] = 2;

                        }
                    }
                }

                distdotopo = r.Next(2, 20);
                comprimento = r.Next(2, 20);

            }

        }

        private void Inicializar2()
        {
            Console.BackgroundColor = ConsoleColor.Black;

            Random r = new Random();
            int distdotopo = r.Next(2, 20);
            int comprimento = r.Next(2, 20);

            for (int pos =0; pos<_width;pos = pos + 2)
            {
                for(int i =0; i< comprimento; i++)
                {
                    if(distdotopo + i < _height)
                    {
                        if(i<comprimento - 1)
                        {
                            _campo[distdotopo + i, pos] = 1;
                        }
                        else
                        {
                            _campo[distdotopo + i, pos] = 2;
                        }
                    }
                }
            }
            distdotopo = r.Next(2, 20);
            comprimento = r.Next(2, 20);
        }
        private void Descer()
        {
            for(int linha = _height -1; linha >0; linha--)
            {
                for(int pos = 0; pos< _width; pos++)
                {
                    if (_campo[linha, pos] != 0)
                    {
                        int buffer = _campo[linha, pos];
                            if (linha + 1 < _height)
                        {
                            _campo[linha + 1, pos] = buffer;
                            _campo[linha, pos] = 0;
                        }

                    }
                }
            }
        }

        private void Descer2()
        {
            for(int linha =_height -1; linha>0; linha--)
            {
                for (int pos = 0; pos < _width; pos++)
                {
                    Console.MoveBufferArea(pos, linha - 1, 1, 1, pos, linha);
                }
            }
        }
        private void Descer3()
        {
            for(int col = 0; col<_width; col = col + 2)
            {
                for(int lin=_height - 1; lin > 0; lin--)
                {
                    Console.MoveBufferArea(col, lin - 1, 1, 1, col, lin);
                }
            }
        }


    }
}
