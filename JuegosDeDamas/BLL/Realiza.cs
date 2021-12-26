using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Realiza
    {
        private int[] resultado;

        public int[]  Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public int[] RealizaUnaJugada(int x,int y,int ficha)
        {
            Resultado[0]=x;Resultado[1] = y;Resultado[2] = ficha;

            return Resultado;
        }

    }
}

