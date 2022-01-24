using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Ficha
    {
        private int _color;
        private int _posicionX;
        private int _posicionY;

        public int Color
        {
            get { return _color; }
            set { _color = value; }
        }
             

        public int PosicionX
        {
            get { return _posicionX; }
            set { _posicionX = value; }
        }
       

        public int PosicionY
        {
            get { return _posicionY; }
            set { _posicionY = value; }
        }

        //cambio la property posicionX_Y 

    }
}
