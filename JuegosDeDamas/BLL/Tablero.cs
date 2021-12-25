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

        public bool ActualizarMatriz(int x,int y,int ficha)
        {
            this.MatrizdeJuego[x, y] = ficha;
            return true;
        }

        public int[,] MostrarMatriz()
        {
            return MatrizdeJuego;
        }
    }
}
