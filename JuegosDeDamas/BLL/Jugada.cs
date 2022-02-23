using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Jugada
    {
        private bool _movimientoEstado;
        private Turno _turno;


        public int UnTurno
        {
            get { return _turno.Estado; }
            set { _turno.Estado = value; }
        }

        public bool Movimientoestado
        {
            get { return _movimientoEstado; }
            set { _movimientoEstado = value; }
        }

        public bool MovimientoEstado(int turno, Jugador unjugador)
        {
            bool salida = false;
            if (turno == 1 && Math.Abs(unjugador.PosicionCasillaFinX - unjugador.PosicionFichaInicioX) == 70 &&
                unjugador.PosicionCasillaFinY > unjugador.PosicionFichaInicioY)
            {
                salida = true;
            }
            else if (turno == 2 && Math.Abs(unjugador.PosicionCasillaFinX - unjugador.PosicionFichaInicioX) == 70 &&
                unjugador.PosicionCasillaFinY < unjugador.PosicionFichaInicioY)
            {
                salida = true;
            }

            return salida;
        }
        /// <summary>
        /// Verifica si el movimiento de ataque es correcto 
        /// </summary>
        /// <param name="jugador"></param>
        /// <param name="tablero"></param>
        /// <returns>
        /// si es correcto [posX] [posY] [1]
        /// no es correcto [0] [0] [0]
        /// </returns>
        public int[] MovimientoAtaque(Jugador jugador, int jugadorFichaInicioX, int jugadorFichaInicioY, Tablero tablero)
        {
            int[] resulado = new int[3];

            resulado[0] = 0;
            resulado[1] = 0;
            resulado[2] = 0;

            //pasar sobre un adversario 
            //verificar si no ahiga ficha en destino realiza la jugada de ataque
            //en +-70 tiene que aver un contrincante

            //Posicion tocada  matriz de casilla final
            int XMatrizCasillFinX = tablero.MostrarPosicionTableroAmatriz(jugador.PosicionCasillaFinX, jugador.PosicionCasillaFinY)[0];
            int YMatrizCasillFinY = tablero.MostrarPosicionTableroAmatriz(jugador.PosicionCasillaFinX, jugador.PosicionCasillaFinY)[1];

            //posicion en matriz contrincante izquieda
            int XcontrincanteX = tablero.MostrarPosicionTableroAmatriz(jugador.PosicionCasillaFinX - 70, jugador.PosicionCasillaFinY-70)[0];
            int YcontrincanteY = tablero.MostrarPosicionTableroAmatriz(jugador.PosicionCasillaFinX - 70, jugador.PosicionCasillaFinY-70)[1];

            //posicion en matriz contrincante derecha
            int XcontrincanteXX = tablero.MostrarPosicionTableroAmatriz(jugador.PosicionCasillaFinX + 70, jugador.PosicionCasillaFinY-70)[0];
            int YcontrincanteYY = tablero.MostrarPosicionTableroAmatriz(jugador.PosicionCasillaFinX + 70, jugador.PosicionCasillaFinY-70)[1];

            if (Math.Abs(jugador.PosicionCasillaFinX - jugadorFichaInicioX) == 140 &&
                tablero.EstaLibre(XMatrizCasillFinX, YMatrizCasillFinY) == true)
            {

                if (tablero.MostrarMatriz()[XcontrincanteX, YcontrincanteY] == 2) 
                {
                    resulado[0] = XcontrincanteX;
                    resulado[1] = YcontrincanteY;
                    resulado[2] = 1;
                }
                if (tablero.MostrarMatriz()[XcontrincanteXX, YcontrincanteYY] == 2)
                {
                    resulado[0] = XcontrincanteXX;
                    resulado[1] = YcontrincanteYY;
                    resulado[2] = 1;
                }
            }
            //else if (Math.Abs(jugador.PosicionCasillaFinX - jugador.PosicionFichaInicioX) == 140 &&
            //     tablero.EstaLibre(XMatrizCasillFinX, YMatrizCasillFinY) == true)
            //{
            //    if (tablero.MostrarMatriz()[XcontrincanteX, YcontrincanteY] == 1)
            //    {
            //        resulado[0] = XcontrincanteX;
            //        resulado[1] = YcontrincanteY;
            //        resulado[2] = 1;
            //    }
            //    else if (tablero.MostrarMatriz()[XcontrincanteXX, YcontrincanteYY] == 1)
            //    {
            //        resulado[0] = XcontrincanteXX;
            //        resulado[1] = YcontrincanteYY;
            //        resulado[2] = 1;
            //    }
            //}


            return resulado;
        }

    }
}
