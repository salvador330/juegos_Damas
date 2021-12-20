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

        public bool MovimientoEstado
        {
            get { return _movimientoEstado; }
            set { _movimientoEstado = value; }
        }

    }
}
