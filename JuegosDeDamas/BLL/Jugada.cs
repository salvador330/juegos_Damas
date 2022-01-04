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
            if (unjugador.PosicionCasillaFinX!= unjugador.PosicionFichaInicioX)
            {
                salida = true;
            }

            return salida;
        }



    }
}
