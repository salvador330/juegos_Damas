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

        Jugador JugadorRojo = new Jugador("Rojo");
        Jugador JugadorAzul = new Jugador("Azul");


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //realizo click sobre casilla 
            MessageBox.Show("casilla");
            
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
        }

        private void pictureBox65_MouseClick(object sender, MouseEventArgs e)
        {
            //realizo click sobre ficha
            //obtengo nombre de ficha picturebox seleccionado
           
            //MessageBox.Show("ficha");
            
        }


        public void PoblarTableroConFichas()
        {
            //POBLAMOS CON FICHAS ROJAS
            pictureBox65.Image = Image.FromFile(@"C:\Users\Salvador.Cirino\Desktop\test\Juegos de Damas\juegos_Damas\JuegosDeDamas\Rojo.jpg");
            pictureBox66.Image = Image.FromFile(@"C:\Users\Salvador.Cirino\Desktop\test\Juegos de Damas\juegos_Damas\JuegosDeDamas\Rojo.jpg");
            pictureBox67.Image = Image.FromFile(@"C:\Users\Salvador.Cirino\Desktop\test\Juegos de Damas\juegos_Damas\JuegosDeDamas\Rojo.jpg");
            pictureBox68.Image = Image.FromFile(@"C:\Users\Salvador.Cirino\Desktop\test\Juegos de Damas\juegos_Damas\JuegosDeDamas\Rojo.jpg");
            pictureBox69.Image = Image.FromFile(@"C:\Users\Salvador.Cirino\Desktop\test\Juegos de Damas\juegos_Damas\JuegosDeDamas\Rojo.jpg");
            pictureBox70.Image = Image.FromFile(@"C:\Users\Salvador.Cirino\Desktop\test\Juegos de Damas\juegos_Damas\JuegosDeDamas\Rojo.jpg");
            pictureBox71.Image = Image.FromFile(@"C:\Users\Salvador.Cirino\Desktop\test\Juegos de Damas\juegos_Damas\JuegosDeDamas\Rojo.jpg");
            pictureBox72.Image = Image.FromFile(@"C:\Users\Salvador.Cirino\Desktop\test\Juegos de Damas\juegos_Damas\JuegosDeDamas\Rojo.jpg");

            //POBLAMOS CON FICHAS AZULES
            pictureBox73.Image = Image.FromFile(@"C:\Users\Salvador.Cirino\Desktop\test\Juegos de Damas\juegos_Damas\JuegosDeDamas\azul.jpg");
            pictureBox74.Image = Image.FromFile(@"C:\Users\Salvador.Cirino\Desktop\test\Juegos de Damas\juegos_Damas\JuegosDeDamas\azul.jpg");
            pictureBox75.Image = Image.FromFile(@"C:\Users\Salvador.Cirino\Desktop\test\Juegos de Damas\juegos_Damas\JuegosDeDamas\azul.jpg");
            pictureBox76.Image = Image.FromFile(@"C:\Users\Salvador.Cirino\Desktop\test\Juegos de Damas\juegos_Damas\JuegosDeDamas\azul.jpg");
            pictureBox77.Image = Image.FromFile(@"C:\Users\Salvador.Cirino\Desktop\test\Juegos de Damas\juegos_Damas\JuegosDeDamas\azul.jpg");
            pictureBox78.Image = Image.FromFile(@"C:\Users\Salvador.Cirino\Desktop\test\Juegos de Damas\juegos_Damas\JuegosDeDamas\azul.jpg");
            pictureBox79.Image = Image.FromFile(@"C:\Users\Salvador.Cirino\Desktop\test\Juegos de Damas\juegos_Damas\JuegosDeDamas\azul.jpg");
            pictureBox80.Image = Image.FromFile(@"C:\Users\Salvador.Cirino\Desktop\test\Juegos de Damas\juegos_Damas\JuegosDeDamas\azul.jpg");
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
    }
}
