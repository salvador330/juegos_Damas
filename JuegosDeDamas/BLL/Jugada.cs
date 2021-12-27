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


        public Turno UnTurno
        {
            get { return _turno; }
            set { _turno = value; }
        }

        public bool MovimientoEstado
        {
            get { return _movimientoEstado; }
            set { _movimientoEstado = value; }
        }


        
    }
}
