using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Turno
    {
        private Jugador jugador;
        private string _horaInicio;
        private string  _horaFin;
        private int _cantidadFichasJugadorRojo;
        private int _cantidadFichasJugadorAzul;
        private bool _estado;

        public bool Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public int CantidadFichasJugadorAzul
        {
            get { return _cantidadFichasJugadorAzul; }
            set { _cantidadFichasJugadorAzul = value; }
        }


        public int CantidadFichasJugadorRojo
        {
            get { return _cantidadFichasJugadorRojo; }
            set { _cantidadFichasJugadorRojo = value; }
        }


        public string HoraFin    
        {
            get { return _horaFin; }
            set { _horaFin = value; }
        }

        public string HoraInicio
        {
            get { return _horaInicio; }
            set { _horaInicio = value; }
        }

        public Jugador Unjugador
        {
            get { return jugador; }
            set { jugador = value; }
        }

        public bool IniciarContador()
        {
            return true;
        }

        public bool CambiarEstado()
        {
            return true;
        }

        public bool IndicarEstado()
        {
            return Estado;
        }

    }
}
