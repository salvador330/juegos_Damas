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
            if (turno==1 && Math.Abs(unjugador.PosicionCasillaFinX - unjugador.PosicionFichaInicioX)==70)
            {
                salida = true;
            }
            else if(turno == 2 && Math.Abs(unjugador.PosicionCasillaFinX - unjugador.PosicionFichaInicioX) == 70)
             {
                salida = true;
            }

            return salida;
        }



    }
}
