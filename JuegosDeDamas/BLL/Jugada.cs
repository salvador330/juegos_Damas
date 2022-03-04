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

            //rojo
            //posicion en matriz contrincante izquieda
            int XcontrincanteX = tablero.MostrarPosicionTableroAmatriz(jugador.PosicionCasillaFinX - 70, jugador.PosicionCasillaFinY-70)[0];
            int YcontrincanteY = tablero.MostrarPosicionTableroAmatriz(jugador.PosicionCasillaFinX - 70, jugador.PosicionCasillaFinY-70)[1];

            //posicion en matriz contrincante derecha
            int XcontrincanteXX = tablero.MostrarPosicionTableroAmatriz(jugador.PosicionCasillaFinX + 70, jugador.PosicionCasillaFinY-70)[0];
            int YcontrincanteYY = tablero.MostrarPosicionTableroAmatriz(jugador.PosicionCasillaFinX + 70, jugador.PosicionCasillaFinY-70)[1];

            //azul
            //posicion en matriz contrincante izquieda
            int XcontrincanteXXX = tablero.MostrarPosicionTableroAmatriz(jugador.PosicionCasillaFinX - 70, jugador.PosicionCasillaFinY + 70)[0];
            int YcontrincanteYYY = tablero.MostrarPosicionTableroAmatriz(jugador.PosicionCasillaFinX - 70, jugador.PosicionCasillaFinY + 70)[1];

            //posicion en matriz contrincante derecha
            int XcontrincanteXXXX = tablero.MostrarPosicionTableroAmatriz(jugador.PosicionCasillaFinX + 70, jugador.PosicionCasillaFinY + 70)[0];
            int YcontrincanteYYYY = tablero.MostrarPosicionTableroAmatriz(jugador.PosicionCasillaFinX + 70, jugador.PosicionCasillaFinY + 70)[1];

            if (Math.Abs(jugador.PosicionCasillaFinX - jugadorFichaInicioX) == 140 &&
                tablero.EstaLibre(XMatrizCasillFinX, YMatrizCasillFinY) == true &&
                    jugador.Color == 1)
            {

                if (tablero.MostrarMatriz()[XcontrincanteX, YcontrincanteY] == 2 &&
                    jugador.PosicionCasillaFinX >=209 &&
                    jugador.PosicionCasillaFinX <= 699 &&
                    jugadorFichaInicioY< jugador.PosicionCasillaFinY &&
                    ((XMatrizCasillFinX - XcontrincanteX) < 2) &&
                    ((YMatrizCasillFinY - YcontrincanteY) < 2)
                    )
                {
                    resulado[0] = XcontrincanteX;
                    resulado[1] = YcontrincanteY;
                    resulado[2] = 1;
                }
                if (tablero.MostrarMatriz()[XcontrincanteXX, YcontrincanteYY] == 2 &&
                    jugador.PosicionCasillaFinX >= 209 &&
                    jugador.PosicionCasillaFinX <= 699 &&
                    jugadorFichaInicioY < jugador.PosicionCasillaFinY &&
                    ((XMatrizCasillFinX - XcontrincanteXX) < 2 &&
                    ((YMatrizCasillFinY - YcontrincanteYY) < 2))
                    )
                {
                    resulado[0] = XcontrincanteXX;
                    resulado[1] = YcontrincanteYY;
                    resulado[2] = 1;
                }
            }
            else if (
                 tablero.EstaLibre(XMatrizCasillFinX, YMatrizCasillFinY) == true &&
                    jugador.Color == 2)
            {
                if (tablero.MostrarMatriz()[XcontrincanteXXX, YcontrincanteYYY] == 1 &&
                    jugador.PosicionCasillaFinX >= 209 &&
                    jugador.PosicionCasillaFinX <= 699 &&
                    ((XMatrizCasillFinX- XcontrincanteXXX)< 2 &&
                    ((YMatrizCasillFinY - YcontrincanteYYY) < 2)
                    )
                    )
                {
                    resulado[0] = XcontrincanteXXX;
                    resulado[1] = YcontrincanteYYY;
                    resulado[2] = 1;
                }
                if (tablero.MostrarMatriz()[XcontrincanteXXXX, YcontrincanteYYYY] == 1 &&
                    jugador.PosicionCasillaFinX >= 209 &&
                    jugador.PosicionCasillaFinX <= 699 &&
                    ((XMatrizCasillFinX - XcontrincanteXXXX) < 2 &&
                    ((YMatrizCasillFinY - YcontrincanteYYYY) < 2)
                    )
                    )
                {
                    resulado[0] = XcontrincanteXXXX;
                    resulado[1] = YcontrincanteYYYY;
                    resulado[2] = 1;
                }
            }


            return resulado;
        }

    }
}
