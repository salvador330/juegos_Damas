using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Jugador
    {
        private int _color;
        private int _cantidadfichas;
        private int _posicionFichaInicioX;
        private int _posicionFichaInicioY;
        private int _posicionCasillaFinX;
        private int _posicionCasillaFinY;
        private Tablero _tablero=new Tablero();
        private Jugada _jugada=new Jugada();

        public Jugada UnJugada
        {
            get { return _jugada; }
            set { _jugada = value; }
        }

        public Tablero UnTablero
        {
            get { return _tablero; }
            set { _tablero = value; }
        }
 

        public Jugador(int color)
        {
            this.Color = color;
            this.CantidadFichas = 8;
        }

        public Jugador()
        {

        }

        public int Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int CantidadFichas
        {
            get { return _cantidadfichas; }
            set { _cantidadfichas = value; }
        }
     
        public int PosicionFichaInicioX
        {
            get { return _posicionFichaInicioX; }
            set { _posicionFichaInicioX = value; }
        }

        public int PosicionFichaInicioY
        {
            get { return _posicionFichaInicioY; }
            set { _posicionFichaInicioY = value; }
        }

        public int PosicionCasillaFinX
        {
            get { return _posicionCasillaFinX; }
            set { _posicionCasillaFinX = value; }
        }

        public int PosicionCasillaFinY
        {
            get { return _posicionCasillaFinY; }
            set { _posicionCasillaFinY = value; }
        }

        public bool IniciarJuego()
        {
            UnTablero.IniciarMatriz();
          
            return true;
        }

        public bool FinalizarJuego(int fin)
        {
            UnJugada.UnTurno.HoraFin = fin;
            return true;
        }


        public bool SeleccionarCasillaFin(int posX, int posY)
        {
            this.PosicionCasillaFinX = posX;
            this.PosicionCasillaFinY = posY;

            return true;
        }

        public bool SeleccionarIniciodeFicha(Ficha ficha)
        {
            UnTablero.ActualizarMatriz(ficha.PosicionX, ficha.PosicionY, ficha.Color);

            return true;
        }

        public bool RealizarJugada()
        {
            return true;
        }

        public bool ActualizarJuego()
        {
            return true;
        }

    }
}
