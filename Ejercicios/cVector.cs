using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class cVector
    {
        public int sx1 = 0;
        public int sx2 = 600;
        public int sy1 = 0;
        public int sy2 = 500;
        public double x1 = -10;
        public double x2 = 10;
        public double y1 = -8.33;
        public double y2 = 8.33;
        public double Xo;
        public double Yo;
        public Color color0;
        public Color[] paleta0 = new Color[16];
        public Color[] paleta1 = new Color[16];
        public Color[] PaletaT = new Color[3];
        public Color[] PaletaFuego = new Color[16];

        public cVector()
        {
            paleta0[0] = Color.Black;
            paleta0[1] = Color.Navy;
            paleta0[2] = Color.Green;
            paleta0[3] = Color.Aqua;
            paleta0[4] = Color.Red;
            paleta0[5] = Color.Purple;
            paleta0[6] = Color.Maroon;
            paleta0[7] = Color.LightGray;
            paleta0[8] = Color.DarkGray;
            paleta0[9] = Color.Blue;
            paleta0[10] = Color.Lime;
            paleta0[11] = Color.Silver;
            paleta0[12] = Color.Teal;
            paleta0[13] = Color.Fuchsia;
            paleta0[14] = Color.Yellow;
            paleta0[15] = Color.White;

            paleta1[1] = Color.Orange;
            paleta1[2] = Color.DeepPink;
            paleta1[3] = Color.DarkGreen;
            paleta1[4] = Color.Indigo;
            paleta1[5] = Color.DarkSlateGray;
            paleta1[6] = Color.Gold;
            paleta1[7] = Color.Turquoise;
            paleta1[8] = Color.DarkOrange;
            paleta1[9] = Color.MediumPurple;
            paleta1[10] = Color.LimeGreen;
            paleta1[11] = Color.SaddleBrown;
            paleta1[12] = Color.MediumSlateBlue;
            paleta1[13] = Color.Orchid;
            paleta1[14] = Color.SpringGreen;
            paleta1[15] = Color.PaleGoldenrod;

            PaletaT[0] = Color.FromArgb(130, 70, 30);
            PaletaT[1] = Color.FromArgb(163, 12, 0);
            PaletaT[1] = Color.FromArgb(250, 100, 50);

            PaletaFuego[0] = Color.FromArgb(138, 4, 38);
            PaletaFuego[1] = Color.FromArgb(219, 13, 74);
            PaletaFuego[3] = Color.FromArgb(230, 90, 75);
            PaletaFuego[4] = Color.FromArgb(245, 59, 31);
            PaletaFuego[5] = Color.FromArgb(169, 0, 0);
   

        }


        public cVector(double Xo, double Yo, Color color0)
        {
            this.Xo = Xo;
            this.Yo = Yo;
            this.color0 = color0;
        }

        public void Pantalla(double x, double y, out int sx, out int sy)
        {
            sx = (int)(((x - x1) / (x1 - x2)) * (sx1 - sx2) + sx1);
            sy = (int)(((y - y2) / (y2 - y1)) * (sy1 - sy2) + sy1);
        }

        public virtual void Encender(Bitmap pixelVec)
        {
            int Sx, Sy;
            Pantalla(Xo, Yo, out Sx, out Sy);
            if (Sx >= 0 && Sx < 600 && Sy >= 0 && Sy < 500)
            {
                try
                {
                    pixelVec.SetPixel(Sx, Sy, color0);
                }
                catch { }
            }
        }
    }
}