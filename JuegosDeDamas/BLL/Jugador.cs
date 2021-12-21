using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Jugador
    {
        private string _color;
        private int _cantidadfichas;
        private int _posicionFichaInicio;
        private int _posicionCasillaFin;

        public Jugador(string color)
        {
            this.Color = color;
            this.CantidadFichas = 8;
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int CantidadFichas
        {
            get { return _cantidadfichas; }
            set { _cantidadfichas = value; }
        }
     
        public int PosicionFichaInicio
        {
            get { return _posicionFichaInicio; }
            set { _posicionFichaInicio = value; }
        }

        public int PosicionCasillaFin
        {
            get { return _posicionCasillaFin; }
            set { _posicionCasillaFin = value; }
        }

        public bool IniciarJuego()
        {

            return true;
        }

        public bool FinalizarJuego()
        {
            return true;
        }


        public bool SeleccionarCasillaFin()
        {
            return true;
        }

        public bool SeleccionarIniciodeFicha()
        {
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
