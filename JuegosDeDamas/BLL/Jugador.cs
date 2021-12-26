﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Jugador
    {
        private int _color;
        private int _cantidadfichas;
        private int _posicionFichaInicio;
        private int _posicionCasillaFin;
        private Tablero _tablero;
        private Jugada _jugada;

        public Jugada UnJugada
        {
            get { return _jugada; }
            set { _jugada = value; }
        }

        public Tablero UnTablero
        {
            get { return _tablero; }
            set { _tablero = value; }
        }
 

        public Jugador(int color)
        {
            this.Color = color;
            this.CantidadFichas = 8;
        }

        public Jugador()
        {

        }

        public int Color
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
            UnTablero.IniciarMatriz();

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

        public bool SeleccionarIniciodeFicha(int x,int y)
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
