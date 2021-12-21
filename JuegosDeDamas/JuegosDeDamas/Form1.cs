using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace JuegosDeDamas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Jugador JugadorRojo = new Jugador("Rojo");
        Jugador JugadorAzul = new Jugador("Azul");


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //evento cuando se toca sobre el tablero donde estan las fichas
           // MessageBox.Show("toco"+Form1.MousePosition.X);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //posicionar todas las fichas
            //comenzar a correr el tiempo
            //iniciar el Turno
            //bloquear boton inicio

        }
    }
}
