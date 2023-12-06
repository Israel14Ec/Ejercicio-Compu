using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class CurvaV
    {
        int tipo = 0;
        public double Xo;
        public double Yo;
        public double Xf;
        public double Yf;
        public Color color0;
        int Rd = 1;
        public CurvaV()
        {
        }
        public CurvaV(double X0, double Y0, double Xf, double Yf, Color color0)
        {
            this.Xo = X0;
            this.Yo = Y0;
            this.Xf = Xf;
            this.Yf = Yf;
            this.color0 = color0;
        }

        public virtual void EncenderCV(Bitmap pixelVec)
        {
            double t = 0;
            double dt = 0.001;

            cVector v = new cVector(0, 0, color0);

            if (tipo == 0)
            {
                do
                {
                    v.Xo = -5 + 2 * Rd * Math.Sin(2 * t);
                    v.Yo = -1 + 2 * Rd * Math.Sin(3 * t);
                    v.color0 = this.color0;
                    v.Encender(pixelVec);
                    t += dt;
                } while (t <= 2 * (Math.PI));
            }
        }

        public virtual void EncenderCV2(Bitmap pixelVec)
        {
            double t = 0;
            double dt = 0.001;

            cVector v = new cVector();

            do
            {
                v.Xo = 1 + 2 * Rd * (Math.Cos(4 * t) * Math.Cos(t));
                v.Yo = 1 + 2 * Rd * (Math.Cos(4 * t) * Math.Sin(t));
                v.color0 = this.color0;
                v.Encender(pixelVec);
                t = t + dt;

            } while (t <= 2 * (Math.PI));
        }

        public virtual void EncenderCV3(Bitmap pixelVec)
        {
            double t = 0;
            double dt = 0.001;

            cVector v = new cVector();

            do
            {
                v.Xo = -5 + 2 * Rd * Math.Pow(Math.Sin(t), 3);
                v.Yo =  4 + 2 * Rd * Math.Pow(Math.Cos(t), 3);
                v.color0 = this.color0;
                v.Encender(pixelVec);
                t = t + dt;

            } while (t <= 2 * (Math.PI));
        }

        public virtual void EncenderCV4(Bitmap pixelVec, int x, int y, int pos)
        {
            double t = 0;
            double dt = 0.001;

            cVector v = new cVector();

            do
            {
                v.Xo = x + pos * Rd * (Math.Sin((8 * t) / 5) * Math.Cos(t));
                v.Yo = y + pos * Rd * (Math.Sin((8 * t) / 5) * Math.Sin(t));
                v.color0 = this.color0;
                v.Encender(pixelVec);
                t = t + dt;

            } while (t <= 10 * (Math.PI));
        }
    }
}