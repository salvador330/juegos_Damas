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
        //variable inicio de juego
        bool JuegoStart = false;
        //variables auxiliares para timer
        int tiempoParcialSegundos = 0, timepoParcialMinuto=0;

        Jugador JugadorRojo = new Jugador(1);
        Jugador JugadorAzul = new Jugador(2);
        Turno UnTurno = new Turno();
        

        PictureBox poicionFicha;
        PictureBox posicioCasilla;

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //realizo click sobre casilla 

            //debo validar si se puede mover la ficha
            //label25.Text = UnTurno.Estado.ToString();
            label25.Text = UnTurno.TurnoString();
            posicioCasilla = (PictureBox)sender;

            //obtenermos las posiciones de Casilla y Ficha
            JugadorRojo.PosicionCasillaFinX = posicioCasilla.Location.X;
            JugadorRojo.PosicionCasillaFinY = posicioCasilla.Location.Y;
            JugadorAzul.PosicionCasillaFinX = posicioCasilla.Location.X;
            JugadorAzul.PosicionCasillaFinY = posicioCasilla.Location.Y;

            Console.WriteLine(UnTurno.Estado);
            Console.WriteLine("ficha "+poicionFicha.Location.X + " " + poicionFicha.Location.Y);
            Console.WriteLine("casilla " + posicioCasilla.Location.X + " " + posicioCasilla.Location.Y);
            if (JuegoStart == true && UnTurno.IndicarEstado() == 1 && 
                JugadorRojo.UnJugada.MovimientoEstado(UnTurno.Estado,JugadorRojo)==true)
            {
                


                //JugadorRojo.PosicionCasillaFinX = posicioCasilla.Location.X;
                //JugadorRojo.PosicionCasillaFinY = posicioCasilla.Location.Y;


                poicionFicha.Location = new Point(JugadorRojo.PosicionCasillaFinX, JugadorRojo.PosicionCasillaFinY);
                UnTurno.CambiarEstado();
                label25.Text = UnTurno.TurnoString();
            }

            else if (JuegoStart == true && UnTurno.IndicarEstado() == 2 &&
                JugadorAzul.UnJugada.MovimientoEstado(UnTurno.Estado, JugadorAzul) == true)
            {

                //JugadorAzul.PosicionCasillaFinX = posicioCasilla.Location.X;
                //JugadorAzul.PosicionCasillaFinY = posicioCasilla.Location.Y;

                poicionFicha.Location = new Point(JugadorAzul.PosicionCasillaFinX, JugadorAzul.PosicionCasillaFinY);
                UnTurno.CambiarEstado();
                label25.Text = UnTurno.TurnoString();
            }
            //tengo que hacer un if para verificar si se realizo un movimiento de ataque
            //debo actualizar la matrix con los movimientos, para leer o modificar
            //ejemplo JuegoStar=true && Turno=1 &&
            //MovimientoAtaque(ficha,casilla)=true => se come la ficha central
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
            JuegoStart = true;
            label25.Text = UnTurno.TurnoString();
        }

        private void pictureBox65_MouseClick(object sender, MouseEventArgs e)
        {
            //realizo click sobre ficha
            //obtengo nombre de ficha picturebox seleccionado
            poicionFicha = (PictureBox)sender;
            //label25.Text = UnTurno.Estado.ToString();
            label25.Text = UnTurno.TurnoString();



            if (UnTurno.IndicarEstado()==1 && TocoFichaRoja(sender) && JuegoStart==true)
            {
                //permitir mover las rojas
               
                JugadorRojo.PosicionFichaInicioX = poicionFicha.Location.X;
                JugadorRojo.PosicionFichaInicioY = poicionFicha.Location.Y;
                JugadorRojo.Nombre = sender;
                
         
               
            }
            else if (UnTurno.IndicarEstado()==2 && TocoFichaAzul(sender) && JuegoStart == true)
            {
                //permite mover las azules
                JugadorAzul.PosicionFichaInicioX = poicionFicha.Location.X;
                JugadorAzul.PosicionFichaInicioY = poicionFicha.Location.Y;
                JugadorAzul.Nombre = sender;
              
                
            }
            
        }


        public void PoblarTableroConFichas()
        {
            //direccion de imagenes
            string direccionImagenes = @"C:\Users\Salvador.Cirino\Desktop\test\Juegos de Damas\juegos_Damas\JuegosDeDamas\";

            //POBLAMOS CON FICHAS ROJAS
            rojo65.Image = Image.FromFile(direccionImagenes + "Rojo.jpg");
            rojo66.Image = Image.FromFile(direccionImagenes + "Rojo.jpg");
            rojo67.Image = Image.FromFile(direccionImagenes + "Rojo.jpg");
            rojo68.Image = Image.FromFile(direccionImagenes + "Rojo.jpg");
            rojo69.Image = Image.FromFile(direccionImagenes + "Rojo.jpg");
            rojo70.Image = Image.FromFile(direccionImagenes + "Rojo.jpg");
            rojo71.Image = Image.FromFile(direccionImagenes + "Rojo.jpg");
            rojo72.Image = Image.FromFile(direccionImagenes + "Rojo.jpg");

            //POBLAMOS CON FICHAS AZULES
            azul73.Image = Image.FromFile(direccionImagenes + "azul.jpg");
            azul74.Image = Image.FromFile(direccionImagenes + "azul.jpg");
            azul75.Image = Image.FromFile(direccionImagenes + "azul.jpg");
            azul76.Image = Image.FromFile(direccionImagenes + "azul.jpg");
            azul77.Image = Image.FromFile(direccionImagenes + "azul.jpg");
            azul78.Image = Image.FromFile(direccionImagenes + "azul.jpg");
            azul79.Image = Image.FromFile(direccionImagenes + "azul.jpg");
            azul80.Image = Image.FromFile(direccionImagenes + "azul.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //finalizar juego
            timer1.Enabled = false;
            button1.Enabled = true;
            tiempoParcialSegundos = 0; timepoParcialMinuto = 0;
            JuegoStart = false;
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
            if (pb.Name== "rojo65" || pb.Name == "rojo66" || pb.Name == "rojo67" ||
                pb.Name == "rojo68" || pb.Name == "rojo69" || pb.Name == "rojo70" ||
                pb.Name == "rojo71" || pb.Name == "rojo72")
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
            if (pb.Name == "azul73" || pb.Name == "azul74" || pb.Name == "azul75" ||
                pb.Name == "azul76" || pb.Name == "azul77" || pb.Name == "azul78" ||
                pb.Name == "azul79" || pb.Name == "azul80")
            {
                resultado = true;
            }

            return resultado;
        }
    }
}
