using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Form1 : Form
    {
        Bitmap pixelVec = new Bitmap(600, 500);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cSegmento S = new cSegmento();

            S.Xo = -10;
            S.Yo = -2;
            S.Xf = 6;
            S.Yf = 4;
            S.EncenderS(pixelVec, Color.Pink);
            
            S.Xo = 6;
            S.Yo = 4;
            S.Xf = 6;
            S.Yf = -2;
            S.EncenderS(pixelVec, Color.Yellow);

            S.Xo = 6;
            S.Yo = -2;
            S.Xf = 10;
            S.Yf = 5;
            S.EncenderS(pixelVec, Color.Green);

            pictureBox1.Image = pixelVec;

            cCircunferencia C = new cCircunferencia();
            C.Xo = 1;
            C.Yo = 3;
            C.Rd = 2;
            C.EncenderC(pixelVec, Color.Red);

            C.Xo = 1;
            C.Yo = 3.5;
            C.Rd = 1;
            C.EncenderC(pixelVec, Color.Pink);

            C.Xo = 6;
            C.Yo = 4;
            C.Rd = 1;
            C.EncenderC(pixelVec, Color.Brown);
            pictureBox1.Image = pixelVec;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurvaV V = new CurvaV();
            V.color0 = Color.Yellow;
            V.EncenderCV(pixelVec);
            pictureBox1.Image = pixelVec;

            CurvaV V2 = new CurvaV();
            V2.color0 = Color.Green;
            V2.EncenderCV2(pixelVec);
            pictureBox1.Image = pixelVec;

            CurvaV V3 = new CurvaV();
            V3.color0 = Color.Red;
            V3.EncenderCV3(pixelVec);
            pictureBox1.Image = pixelVec;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CurvaV V4 = new CurvaV();
            V4.color0 = Color.Green;
            V4.EncenderCV4(pixelVec, -4, 3, 2);


            V4.color0 = Color.Yellow;
            V4.EncenderCV4(pixelVec, -4, -2, 3);


            V4.color0 = Color.Gray;
            V4.EncenderCV4(pixelVec, 4, 2, 1);
            pictureBox1.Image = pixelVec;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cSegmento S = new cSegmento();
            S.Xo = 10;
            S.Yo = 0;
            S.Xf = -10;
            S.Yf = 0;
            S.EncenderS(pixelVec, Color.Blue);

            S.Xo = 0;
            S.Yo = 8;
            S.Xf = 0;
            S.Yf = -8;
            S.EncenderS(pixelVec, Color.Blue);

            pictureBox1.Image = pixelVec;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            cVector v = new cVector();

            double t = -8;

            do
            {
                v.Xo = t;
                v.Yo = Math.Pow(2, t);
                v.color0 = Color.Coral;
                v.Encender(pixelVec);

                v.Yo = (Math.Pow(t, 2) / 5) - 3;
                v.color0 = Color.Black;
                v.Encender(pixelVec);

                v.Yo = Math.Log(t);
                v.color0 = Color.Yellow;
                v.Encender(pixelVec);

                v.Yo = Math.Sin(t);
                v.color0 = Color.DarkBlue;
                v.Encender(pixelVec);

                v.Yo = Math.Pow(t, 3) / 4;
                v.color0 = Color.Pink;
                v.Encender(pixelVec);

                t = t + 0.001;

            } while (t <= 8);

            pictureBox1.Image = pixelVec;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cVector v = new cVector();
            double t = -8;

            do
            {
                v.Xo = t;
                v.Yo = Math.Pow(3, t);
                v.color0 = Color.Coral;
                v.Encender(pixelVec);

                v.Yo = 1 + 1.098 * (t - 0) + ((1.206) * Math.Pow((t - 0), 2) / 2)
    + (1.206 * Math.Pow(t - 0, 3) * Math.Log(3)) / 6
    + (1.206 * Math.Pow(t - 0, 4) * Math.Pow(Math.Log(3), 2)) / 24;

                v.color0 = Color.Black;
                v.Encender(pixelVec);

                t = t + 0.001;

            } while (t <= 8);

            pictureBox1.Image = pixelVec;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            cVector v = new cVector();
  
            double x = -10;
            double dx = 0.001;

            do
            {
                v.Xo = x;
                v.Yo = (-0.03) * Math.Pow(x, 2) + 3;
                v.color0 = Color.DarkOrange;
                v.Encender(pixelVec);
                x = x + dx;


            } while (x <= 10);

            pictureBox1.Image = pixelVec;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            cSegmento s = new cSegmento();

            double x = 3;
            double y = (-0.003) * Math.Pow(x, 2) + 3;
            double m = -0.06 * x;
            s.Xo = -10;
            s.Xf = 10;
            s.Yo = m * (s.Xo - x) + y;
            s.Yf = m * (s.Xf - x) + y;
            s.EncenderS(pixelVec, Color.Pink);

            x = -5;
            y = (-0.003) * Math.Pow(x, 2) + 3;
            m = -0.06 * x;
            s.Xo = -10;
            s.Xf = 10;
            s.Yo = m * (s.Xo - x) + y;
            s.Yf = m * (s.Xf - x) + y;
            s.EncenderS(pixelVec, Color.Green);

            x = -7;
            y = (-0.003) * Math.Pow(x, 2) + 3;
            m = -0.06 * x;
            s.Xo = -10;
            s.Xf = 10;
            s.Yo = m * (s.Xo - x) + y;
            s.Yf = m * (s.Xf - x) + y;
            s.EncenderS(pixelVec, Color.Yellow);

            pictureBox1.Image = pixelVec;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pixelVec = new Bitmap(600, 500); // Crear un nuevo objeto Bitmap vacío
            pictureBox1.Image = pixelVec;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cVector v = new cVector();

            int colorT;
            Color c;


            for (int i =0; i<600; i++)
            {
                for(int j=0; j<500; j++)
                {
                    colorT = (i * i + j * j)%15;
                    //colorT = (int)(Math.Abs(Math.Sin(i)) * Math.Log(j + 1) % 15);
                    c = v.paleta0[colorT];
                    pixelVec.SetPixel(i, j, c);

                }
            }

            pictureBox1.Image = pixelVec;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cVector v = new cVector();

            int colorT;
            Color c;


            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    //colorT = (i * i + j * j)%15;
                    colorT = (int)(Math.Abs(Math.Sin(i)) * Math.Log(j + 1) % 15);
                    c = v.paleta1[colorT];
                    pixelVec.SetPixel(i, j, c);

                }
            }

            pictureBox1.Image = pixelVec;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cVector v = new cVector();

            string opcionSeleccionada = comboBox1.SelectedItem.ToString();
            int colorT;
            Color c;

            // Imprime algo diferente según la opción seleccionada
            switch (opcionSeleccionada)
            {
                case "Diseño 1":

                    for (int i = 0; i < 600; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {

                            colorT = (int)((Math.Abs(Math.Sin(i * 0.1)) + 0.1 * Math.Pow((j - 300), 2) * 0.001) % 15);
                            c = v.paleta0[colorT];
                            pixelVec.SetPixel(i, j, c);

                        }
                    }

                    break;
                case "Diseño 2":
                    for (int i = 0; i < 600; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {
   
                            colorT = (int) ( (j * (j*2)) + Math.Cos(i)) %15;
                            c = v.paleta1[colorT];
                            pixelVec.SetPixel(i, j, c);

                        }
                    }

                    break;

                case "Diseño 3":
                    
                    for (int i = 0; i < 600; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {

                            colorT = (int)((i * 0.05) + Math.Sin(j)) % 15;
                            c = v.paleta1[colorT];
                            pixelVec.SetPixel(i, j, c);

                        }
                    }
                    break;

                case "Diseño 4":
                     for (int i = 0; i < 600; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {

                            colorT = (int)(Math.Pow(2, j * 0.04) % 15);
                            c = v.paleta1[colorT];
                            pixelVec.SetPixel(i, j, c);

                        }
                    }
                    break;

                case "Diseño 5":
                    for (int i = 0; i < 600; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {

                            colorT = (int)((Math.Abs(Math.Sin(i * 0.1)) * Math.Pow(2, j * 0.01)) % 15);
                            c = v.paleta1[colorT];
                            pixelVec.SetPixel(i, j, c);

                        }
                    }
                    break;

                case "Diseño 6":
                    for (int i = 0; i < 600; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {

                            colorT = (int)(Math.Abs(Math.Cos(i * 0.05)) * 10);
                            c = v.paleta1[colorT];
                            pixelVec.SetPixel(i, j, c);

                        }
                    }

                    break;

                case "Diseño 7":
                    for (int i = 0; i < 600; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {

                            colorT = (int)((Math.Abs(Math.Sin(i * 0.02)) * Math.Pow(2, j * 0.02) + Math.Sin(j * 0.05)) % 5);
                            c = v.paleta1[colorT];
                            pixelVec.SetPixel(i, j, c);

                        }
                    }
                    break;

                case "Diseño 8":
                    for (int i = 0; i < 600; i++)
                    {
                        for (int j = 0; j < 500; j++)
                        {
                            double xNormalized = (double)i / 600;
                            double yNormalized = (double)j / 500;

                            colorT = (int)(Math.Abs(Math.Sin(xNormalized * 10) * Math.Sin(yNormalized * Math.PI)) * 15);
                            c = v.paleta1[colorT];
                            pixelVec.SetPixel(i, j, c);
                        }
                    }
                    break;


                default:
                    // Si se selecciona algo que no esperabas
                    Console.WriteLine("Opción no reconocida");
                    break;
            }

            pictureBox1.Image = pixelVec;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cVector v = new cVector();
            int colorT;
            Color c;

            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
     
                    colorT = (int)(Math.Sqrt(i + 50.5) + Math.Cos(i) + 10 * j / 2.3)%3;
                    c = v.PaletaT[colorT];
                    pixelVec.SetPixel(i, j, c);
                }
            }
            pictureBox1.Image = pixelVec;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            cVector v = new cVector();
            int colorT;
            Color c;

            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = (int)(Math.Abs(Math.Sin(i * 0.2)) + Math.Abs(Math.Cos(j * 0.002)) 
                        + Math.Abs(Math.Sin((i + j) * 0.20)) + Math.Abs(1.8 * Math.Sin(i * 0.3)) 
                        + Math.Abs(1.2 * Math.Cos(j * 0.10)))%4;
                    //colorT = (colorT < 0) ? 1 : (colorT >= v.PaletaFuego.Length) ? v.PaletaFuego.Length - 1 : colorT;
                    c = v.PaletaFuego[colorT];
                    pixelVec.SetPixel(i, j, c);
                }
            }
            pictureBox1.Image = pixelVec;
        }
    }
}
