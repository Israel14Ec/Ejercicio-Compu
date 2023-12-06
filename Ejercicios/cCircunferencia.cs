using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class cCircunferencia : cVector
    {
        public double Rd;

        public cCircunferencia() { }

        public cCircunferencia(double Rd, Color color0)
        {
            this.Rd = Rd;
            this.color0 = color0;
        }

        public virtual void EncenderC(Bitmap pixelVec, Color color)
        {
            double pi = 3.1416;
            double t = -pi;
            double dt = 0.0001;

            cVector v = new cVector();

            do
            {
                v.Xo = this.Xo + Rd * Math.Cos(t);
                v.Yo = this.Yo + Rd * Math.Sin(t);
                v.color0 = color;
                v.Encender(pixelVec);
                t += dt;

            } while (t <= pi);
        }
    }
}
