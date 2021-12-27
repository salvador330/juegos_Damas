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
        //variables auxiliares para timer
        int tiempoParcialSegundos = 0, timepoParcialMinuto=0;

        Jugador JugadorRojo = new Jugador(1);
        Jugador JugadorAzul = new Jugador(2);
        Turno UnTurno = new Turno();

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //realizo click sobre casilla 
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //posicionar todas las fichas
            //comenzar a correr el tiempo
            //iniciar el Turno
            //bloquear boton inicio

            PoblarTableroConFichas();
            button1.Enabled = false;
            timer1.Start();
            JugadorRojo.IniciarJuego();
            UnTurno.IniciarContador();
        }

        private void pictureBox65_MouseClick(object sender, MouseEventArgs e)
        {
            //realizo click sobre ficha
            //obtengo nombre de ficha picturebox seleccionado


           
            if (UnTurno.IndicarEstado()==1 && TocoFichaRoja(sender))
            {
                //permitir mover las rojas
                
                UnTurno.CambiarEstado();
                MessageBox.Show("toco roja");
            }
            if (UnTurno.IndicarEstado()==2 && TocoFichaAzul(sender))
            {
                //permite mover las azules
                MessageBox.Show("toco auzul");
                UnTurno.CambiarEstado();
            }
            
        }


        public void PoblarTableroConFichas()
        {
            //direccion de imagenes
            string direccionImagenes = @"C:\Users\Salvador.Cirino\Desktop\test\Juegos de Damas\juegos_Damas\JuegosDeDamas\";

            //POBLAMOS CON FICHAS ROJAS
            pictureBox65.Image = Image.FromFile(direccionImagenes + "Rojo.jpg");
            pictureBox66.Image = Image.FromFile(direccionImagenes + "Rojo.jpg");
            pictureBox67.Image = Image.FromFile(direccionImagenes + "Rojo.jpg");
            pictureBox68.Image = Image.FromFile(direccionImagenes + "Rojo.jpg");
            pictureBox69.Image = Image.FromFile(direccionImagenes + "Rojo.jpg");
            pictureBox70.Image = Image.FromFile(direccionImagenes + "Rojo.jpg");
            pictureBox71.Image = Image.FromFile(direccionImagenes + "Rojo.jpg");
            pictureBox72.Image = Image.FromFile(direccionImagenes + "Rojo.jpg");

            //POBLAMOS CON FICHAS AZULES
            pictureBox73.Image = Image.FromFile(direccionImagenes + "azul.jpg");
            pictureBox74.Image = Image.FromFile(direccionImagenes + "azul.jpg");
            pictureBox75.Image = Image.FromFile(direccionImagenes + "azul.jpg");
            pictureBox76.Image = Image.FromFile(direccionImagenes + "azul.jpg");
            pictureBox77.Image = Image.FromFile(direccionImagenes + "azul.jpg");
            pictureBox78.Image = Image.FromFile(direccionImagenes + "azul.jpg");
            pictureBox79.Image = Image.FromFile(direccionImagenes + "azul.jpg");
            pictureBox80.Image = Image.FromFile(direccionImagenes + "azul.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //finalizar juego
            timer1.Enabled = false;
            button1.Enabled = true;
            tiempoParcialSegundos = 0; timepoParcialMinuto = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //realiza el conteo de segundo y minutos
            label8.Text = tiempoParcialSegundos.ToString();
            label4.Text = timepoParcialMinuto.ToString();
            if (tiempoParcialSegundos >= 59)
            {
                tiempoParcialSegundos = 0;
                timepoParcialMinuto++;
            }
            tiempoParcialSegundos++;
        }

        public bool TocoFichaRoja(object ficha)
        {
            bool resultado = false;
            PictureBox pb = (PictureBox)ficha;
            string nombre = pb.Name;
            if (pb.Name== "pictureBox65" || pb.Name == "pictureBox66"|| pb.Name == "pictureBox67"||
                pb.Name == "pictureBox68"|| pb.Name == "pictureBox69"|| pb.Name == "pictureBox70"||
                pb.Name == "pictureBox71"|| pb.Name == "pictureBox72")
            {
                resultado = true;
            }

            return resultado;
        }

        public bool TocoFichaAzul(object ficha)
        {
            bool resultado = false;
            PictureBox pb = (PictureBox)ficha;
            string nombre = pb.Name;
            if (pb.Name == "pictureBox73" || pb.Name == "pictureBox74" || pb.Name == "pictureBox75" ||
                pb.Name == "pictureBox76" || pb.Name == "pictureBox77" || pb.Name == "pictureBox78" ||
                pb.Name == "pictureBox79" || pb.Name == "pictureBox80")
            {
                resultado = true;
            }

            return resultado;
        }
    }
}
