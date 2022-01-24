using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Turno
    {

        private int _horaInicio=0;
        private int  _horaFin;
        private int _cantidadFichasJugadorRojo;
        private int _cantidadFichasJugadorAzul;
        private int _estado;

        public int Estado
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


        public int HoraFin    
        {
            get { return _horaFin; }
            set { _horaFin = value; }
        }

        public int HoraInicio
        {
            get { return _horaInicio; }
            
        }

     

        public bool IniciarContador()
        {
            Estado = 1;
            return true;
        }

        public int CambiarEstado()
        {
            if (this.Estado==1)
            {
                this.Estado = 2;
            }
            else if (this.Estado==2)
            {
                this.Estado = 1;
            }
            return this.Estado;
        }

        public int IndicarEstado()
        {
            return Estado;
        }

        public string TurnoString()
        {
            string resultado = "";
            if (this.Estado==1)
            {
                resultado = "Rojo";
            }
            else if (this.Estado == 2)
            {
                resultado = "Azul";
            }
            

            return resultado;
        }

    }
}
