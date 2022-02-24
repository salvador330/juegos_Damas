using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Tablero
    {
        private int[,] _matrizdeJuego;
        private bool _estado=false;


        public int[,] MatrizdeJuego
        {
            get { return _matrizdeJuego; }
            set { _matrizdeJuego = value; }
        }

        public bool Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public bool IniciarMatriz()
        {
            this.Estado = true;
            this.MatrizdeJuego = new int[8, 8] { { 1, 0, 1, 0, 1, 0, 1, 0 },
                                                 { 0, 1, 0, 1, 0, 1, 0, 1 },
                                                 { 0, 0, 0, 0, 0, 0, 0, 0 },
                                                 { 0, 0, 0, 0, 0, 0, 0, 0 },
                                                 { 0, 0, 0, 0, 0, 0, 0, 0 },
                                                 { 0, 0, 0, 0, 0, 0, 0, 0 },
                                                 { 2, 0, 2, 0, 2, 0, 2, 0 },
                                                 { 0, 2, 0, 2, 0, 2, 0, 2 } };
            return true;
        }

        public bool EstaLibre(int x, int y)
        {
            bool resultado = false;

            if (this.MatrizdeJuego[x, y] == 0)
            {
                resultado = true;
            }

            return resultado;
        }

        /// <summary>
        /// Borra la ficha de la matriz
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Retorna la matriz actualizada </returns>
        public int[,] ActualizarTableroComerFicha(int x, int y)
        {
            this.MatrizdeJuego[x, y] = 0;

            return this.MatrizdeJuego;
        }

        /// <summary>
        /// Actualiza el movimiento de las fichas en la matriz
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="ficha"></param>
        /// <returns>Retorna True</returns>
        public bool ActualizarMatriz(int x,int y,int ficha)
        {
            int xx = MostrarPosicionTableroAmatriz(x, y)[0];
            int yy = MostrarPosicionTableroAmatriz(x, y)[1];

            this.MatrizdeJuego[xx, yy] = ficha;
            return true;
        }

        public int[,] MostrarMatriz()
        {
            return this.MatrizdeJuego;
        }

        /// <summary>
        /// Realiza la conversion de matriz a posicion en el tablero
        /// </summary>
        /// <param name="posX"></param>
        /// <param name="posY"></param>
        /// <returns>int[0]=x int[0]=y</returns>
        public int[] MostrarMatrizConversion(int posX, int posY)
        {
            int[] resultado = { 0, 0 };
            //resultado = this.MatrizdeJuego;
            if (posX == 0 && posY == 0)
            {
                resultado[0] = 209;
                resultado[1] = 72;
            }
            else if (posX == 2 && posY == 0)
            {
                resultado[0] = 209;
                resultado[1] = 212;
            }
            else if (posX == 4 && posY == 0)
            {
                resultado[0] = 209;
                resultado[1] = 352;
            }
            else if (posX == 6 && posY == 0)
            {
                resultado[0] = 209;
                resultado[1] = 492;
            }
            else if (posX == 1 && posY == 1)
            {
                resultado[0] = 279;
                resultado[1] = 142;
            }
            else if (posX == 3 && posY == 1)
            {
                resultado[0] = 279;
                resultado[1] = 282;
            }
            else if (posX == 5 && posY == 1)
            {
                resultado[0] = 279;
                resultado[1] = 422;
            }
            else if (posX == 7 && posY == 1)
            {
                resultado[0] = 279;
                resultado[1] = 562;
            }
            else if (posX == 0 && posY == 2)
            {
                resultado[0] = 349;
                resultado[1] = 72;
            }
            else if (posX == 2 && posY == 2)
            {
                resultado[0] = 349;
                resultado[1] = 212;
            }
            else if (posX == 4 && posY == 2)
            {
                resultado[0] = 349;
                resultado[1] = 352;
            }
            else if (posX == 6 && posY == 2)
            {
                resultado[0] = 349;
                resultado[1] = 492;
            }
            else if (posX == 1 && posY == 3)
            {
                resultado[0] = 419;
                resultado[1] = 142;
            }
            else if (posX == 3 && posY == 3)
            {
                resultado[0] = 419;
                resultado[1] = 282;
            }
            else if (posX == 5 && posY == 3)
            {
                resultado[0] = 419;
                resultado[1] = 422;
            }
            else if (posX == 7 && posY == 3)
            {
                resultado[0] = 419;
                resultado[1] = 562;
            }
            else if (posX == 0 && posY == 4)
            {
                resultado[0] = 489;
                resultado[1] = 72;
            }
            else if (posX == 2 && posY == 4)
            {
                resultado[0] = 489;
                resultado[1] = 212;
            }
            else if (posX == 4 && posY == 4)
            {
                resultado[0] = 489;
                resultado[1] = 352;
            }
            else if (posX == 6 && posY == 4)
            {
                resultado[0] = 489;
                resultado[1] = 492;
            }
            else if (posX == 1 && posY == 5)
            {
                resultado[0] = 559;
                resultado[1] = 142;
            }
            else if (posX == 3 && posY == 5)
            {
                resultado[0] = 559;
                resultado[1] = 282;
            }
            else if (posX == 5 && posY == 5)
            {
                resultado[0] = 559;
                resultado[1] = 422;
            }
            else if (posX == 7 && posY == 5)
            {
                resultado[0] = 559;
                resultado[1] = 562;
            }
            else if (posX == 0 && posY == 6)
            {
                resultado[0] = 629;
                resultado[1] = 72;
            }
            else if (posX == 2 && posY == 6)
            {
                resultado[0] = 629;
                resultado[1] = 212;
            }
            else if (posX == 4 && posY == 6)
            {
                resultado[0] = 629;
                resultado[1] = 352;
            }
            else if (posX == 6 && posY == 6)
            {
                resultado[0] = 629;
                resultado[1] = 492;
            }
            else if (posX == 1 && posY == 7)
            {
                resultado[0] = 699;
                resultado[1] = 142;
            }
            else if (posX == 3 && posY == 7)
            {
                resultado[0] = 699;
                resultado[1] = 282;
            }
            else if (posX == 5 && posY == 7)
            {
                resultado[0] = 699;
                resultado[1] = 422;
            }
            else if (posX == 7 && posY == 7)
            {
                resultado[0] = 699;
                resultado[1] = 562;
            }

            return resultado;
        }

        /// <summary>
        /// Realiza la conversion de Posicion en el tablero a Matriz
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns>int[0]=x int[0]=y</returns>
        public int[] MostrarPosicionTableroAmatriz(int posX, int posY)
        {
            int[] resultado = { 0, 0 };
            if (posX == 209 && posY == 72)
            {
                resultado[0] = 0;
                resultado[1] = 0;

            }
            else if (posX == 209 && posY == 212)
            {
                resultado[0] = 2;
                resultado[1] = 0;


            }
            else if (posX == 209 && posY == 352)
            {
                resultado[0] = 4;
                resultado[1] = 0;
            }
            else if (posX == 209 && posY == 492)
            {
                resultado[0] = 6;
                resultado[1] = 0;
            }
            else if (posX == 279 && posY == 142)
            {
                resultado[0] = 1;
                resultado[1] = 1;
            }
            else if (posX == 279 && posY == 282)
            {
                resultado[0] = 3;
                resultado[1] = 1;
            }
            else if (posX == 279 && posY == 422 )
            {
                resultado[0] = 5;
                resultado[1] = 1;
            }
            else if (posX == 279 && posY == 562)
            {
                resultado[0] = 7;
                resultado[1] = 1;
            }
            else if (posX == 349 && posY == 72)
            {
                resultado[0] = 0;
                resultado[1] = 2;
            }
            else if (posX == 349 && posY == 212)
            {
                resultado[0] = 2;
                resultado[1] = 2;
            }
            else if (posX == 349 && posY == 352 )
            {
                resultado[0] = 4;
                resultado[1] = 2;
            }
            else if (posX == 349 && posY == 492 )
            {
                resultado[0] = 6;
                resultado[1] = 2;
            }
            else if (posX == 419 && posY == 142 )
            {
                resultado[0] = 1;
                resultado[1] = 3;
            }
            else if (posX == 419 && posY == 282 )
            {
                resultado[0] = 3;
                resultado[1] = 3;
            }
            else if (posX == 419 && posY == 422 )
            {
                resultado[0] = 5;
                resultado[1] = 3;
            }
            else if (posX == 419 && posY == 562 )
            {
                resultado[0] = 7;
                resultado[1] = 3;
            }
            else if (posX == 489 && posY == 72 )
            {
                resultado[0] = 0;
                resultado[1] = 4;
            }
            else if (posX == 489 && posY == 212 )
            {
                resultado[0] = 2;
                resultado[1] = 4;
            }
            else if (posX == 489 && posY == 352 )
            {
                resultado[0] = 4;
                resultado[1] = 4;
            }
            else if (posX == 489 && posY == 492 )
            {
                resultado[0] = 6;
                resultado[1] = 4;
            }
            else if (posX == 559 && posY == 142 )
            {
                resultado[0] = 1;
                resultado[1] = 5;
            }
            else if (posX == 559 && posY == 282 )
            {
                resultado[0] = 3;
                resultado[1] = 5;
            }
            else if (posX == 559 && posY == 422 )
            {
                resultado[0] = 5;
                resultado[1] = 5;
            }
            else if (posX == 559 && posY == 562 )
            {
                resultado[0] = 7;
                resultado[1] = 5;
            }
            else if (posX == 629 && posY == 72 )
            {
                resultado[0] = 0;
                resultado[1] = 6;
            }
            else if (posX == 629 && posY == 212 )
            {
                resultado[0] = 2;
                resultado[1] = 6;
            }
            else if (posX == 629 && posY == 352 )
            {
                resultado[0] = 4;
                resultado[1] = 6;
            }
            else if (posX == 629  && posY == 492 )
            {
                resultado[0] = 6;
                resultado[1] = 6;
            }
            else if (posX == 699 && posY == 142 )
            {
                resultado[0] = 1;
                resultado[1] = 7;
            }
            else if (posX == 699 && posY == 282 )
            {
                resultado[0] = 3;
                resultado[1] = 7;
            }
            else if (posX == 699 && posY == 422 )
            {
                resultado[0] = 5;
                resultado[1] = 7;
            }
            else if (posX == 699 && posY == 562 )
            {
                resultado[0] = 7;
                resultado[1] = 7;
            }

            return resultado;

        }
    }
}

