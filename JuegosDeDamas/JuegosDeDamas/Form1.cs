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
        Tablero Untablero = new Tablero();

        PictureBox poicionFicha;
        PictureBox posicioCasilla;

        int FichasComidasporRojo = 0;
        int FichasComidasporAzul=0;

        int TempFichaInicioXRojo = 0;//varibale temporaria para recordar posicion de inicio
        int TempFichaInicioYRojo = 0;//varibale temporaria para recordar posicion de inicio
        int TempFichaInicioXAzul = 0;//varibale temporaria para recordar posicion de inicio
        int TempFichaInicioYAzul = 0;//varibale temporaria para recordar posicion de inicio


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
            
            //realizo el movimiento de la ficha, tambien actualizo la matriz
            if (JuegoStart == true && UnTurno.IndicarEstado() == 1 && 
                JugadorRojo.UnJugada.MovimientoEstado(UnTurno.Estado,JugadorRojo)==true)
            {


                Untablero.ActualizarMatriz(JugadorRojo.PosicionFichaInicioX, JugadorRojo.PosicionFichaInicioY, 0);           
                poicionFicha.Location = new Point(JugadorRojo.PosicionCasillaFinX, JugadorRojo.PosicionCasillaFinY);
                Untablero.ActualizarMatriz(JugadorRojo.PosicionCasillaFinX, JugadorRojo.PosicionCasillaFinY, 1);

                

                UnTurno.CambiarEstado();
                label25.Text = UnTurno.TurnoString();
            }
            //realizo el movimiento de la ficha, tambien actualizo la matriz
            else if (JuegoStart == true && UnTurno.IndicarEstado() == 2 &&
                JugadorAzul.UnJugada.MovimientoEstado(UnTurno.Estado, JugadorAzul) == true)
            {
 

                Untablero.ActualizarMatriz(JugadorAzul.PosicionFichaInicioX, JugadorAzul.PosicionFichaInicioY, 0);
                poicionFicha.Location = new Point(JugadorAzul.PosicionCasillaFinX, JugadorAzul.PosicionCasillaFinY);
                Untablero.ActualizarMatriz(JugadorAzul.PosicionCasillaFinX, JugadorAzul.PosicionCasillaFinY, 2);

               

                UnTurno.CambiarEstado();
                label25.Text = UnTurno.TurnoString();
            }
            //tengo que hacer un if para verificar si se realizo un movimiento de ataque
            //debo actualizar la matrix con los movimientos, para leer o modificar
            //ejemplo JuegoStar=true && Turno=1 &&
            //MovimientoAtaque(ficha,casilla)=true => se come la ficha central

            //obtengo la posicion temporal inicial de la ficha
            TempFichaInicioXRojo = JugadorRojo.PosicionFichaInicioX;
            TempFichaInicioYRojo = JugadorRojo.PosicionFichaInicioY;
            TempFichaInicioXAzul = JugadorAzul.PosicionFichaInicioX;
            TempFichaInicioYAzul = JugadorAzul.PosicionFichaInicioY;


            //al realizar el movimiento evaluo si puedo comer ficha
             if (JuegoStart == true  &&
                JugadorRojo.UnJugada.MovimientoAtaque(JugadorRojo, TempFichaInicioXRojo, TempFichaInicioYRojo, Untablero)[2] == 1)
            {
               // Console.WriteLine("rojo come " + JugadorRojo.UnJugada.MovimientoAtaque(JugadorRojo, TempFichaInicioXRojo, TempFichaInicioYRojo, Untablero));
                FichasComidasporAzul++;
                label5.Text = FichasComidasporAzul.ToString();
                Console.WriteLine("A paso por aqui");
                //actualizo matriz
                int x = JugadorRojo.UnJugada.MovimientoAtaque(JugadorRojo, TempFichaInicioXRojo, TempFichaInicioYRojo, Untablero)[0];
                int y = JugadorRojo.UnJugada.MovimientoAtaque(JugadorRojo, TempFichaInicioXRojo, TempFichaInicioYRojo, Untablero)[1];
                Untablero.ActualizarTableroComerFicha(x, y);
                
                //implementar borrar o mover y desahabilitar picture box
                BorrarFicha(x, y);
                TempFichaInicioXRojo = 0;
                TempFichaInicioYRojo = 0;
            }

            //al realizar el movimiento evaluo si puedo comer ficha
            else if (JuegoStart == true  &&
               JugadorAzul.UnJugada.MovimientoAtaque(JugadorAzul, TempFichaInicioXAzul, TempFichaInicioYAzul, Untablero)[2] == 1)
            {
               // Console.WriteLine("azul come " + JugadorAzul.UnJugada.MovimientoAtaque(JugadorAzul, TempFichaInicioXAzul, TempFichaInicioYAzul, Untablero));
               
                
                FichasComidasporRojo++;
                label6.Text = FichasComidasporRojo.ToString();

                Console.WriteLine("B paso por aqui");
                //actualizo matriz
                int x = JugadorAzul.UnJugada.MovimientoAtaque(JugadorAzul, TempFichaInicioXAzul, TempFichaInicioYAzul, Untablero)[0];
                int y = JugadorAzul.UnJugada.MovimientoAtaque(JugadorAzul, TempFichaInicioXAzul, TempFichaInicioYAzul, Untablero)[1];
                Untablero.ActualizarTableroComerFicha(x, y);
                
                //implementar borrar o mover y desahabilitar picture box
                BorrarFicha(x, y);
                TempFichaInicioXAzul = 0;
                TempFichaInicioYAzul = 0;
            }

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
            Untablero.IniciarMatriz();
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
            string direccionImagenes = @"C:\Users\Salvador.Cirino\Desktop\juegos_Damas-Desarrollo Dos\juegos_Damas-Desarrollo\JuegosDeDamas\";

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


        public void BorrarFicha(int x, int y)
        {
            List<PictureBox> lista = new List<PictureBox>() { rojo65, rojo66, rojo67, rojo68, rojo69, rojo70, rojo71 ,
            rojo72,azul73,azul74,azul75,azul76,azul77,azul78,azul79,azul80};
            int posX = Untablero.MostrarMatrizConversion(x, y)[0];
            int posY = Untablero.MostrarMatrizConversion(x, y)[1];

            //obtengo el listado de todos los picture box
            //compraro la posicion x,y
            //obtengo el nombre, borro ficha

            foreach (PictureBox item in lista)
            {
                if (item.Location.X== posX && item.Location.Y== posY)
                {
                    item.Visible = false;
                    Console.WriteLine("- "+ posX + " "+ posY + " "+item.Name);
                }
                Console.WriteLine(item.Location.X + " - " + item.Location.Y + " --" + posX + posY);
            }


        }

    }
}

