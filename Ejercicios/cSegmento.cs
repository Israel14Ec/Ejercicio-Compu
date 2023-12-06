using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class cSegmento : cVector
    {
        public double Xf;
        public double Yf;
        public cSegmento() { }
        public cSegmento(double Xf, double Yf, Color color0)
        {
            this.Xf = Xf;
            this.Yf = Yf;
            this.color0 = color0;
        }

        public virtual void EncenderS(Bitmap pixelVec, Color color)
        {
            double t = 0;
            double dt = 0.001;

            cVector v = new cVector();

            do
            {
                v.Xo = this.Xo + (Xf - this.Xo) * t;
                v.Yo = this.Yo + (Yf - this.Yo) * t;

                v.color0 = color;
                v.Encender(pixelVec);
                t += dt;

            } while (t <= 1);
        }
    }
}
