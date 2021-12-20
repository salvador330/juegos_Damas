using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Tablero
    {
        private List<int[,]> _matrizdeJuego;
        private bool _estado;


        public List<int[,]> MatrizdeJuego
        {
            get { return _matrizdeJuego; }
            set { _matrizdeJuego = value; }
        }

        public bool Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }


    }
}
