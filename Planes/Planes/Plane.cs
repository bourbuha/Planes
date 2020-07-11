using System;
using System.Collections.Generic;
using System.Text;

namespace Plane
{
    class Planeq
    {
        private double A, B, C, D; //Ax+By+Cz+D=0
        public bool och;

        public Planeq()
        {
            A = 0;
            B = 0;
            C = 0;
            D = 0;
            och = true;
        }

        public Planeq(double a, double b, double c, double d)
        {
            if (a != 0 || b != 0 || c != 0)
            {
                A = a;
                B = b;
                C = c;
                D = d;
                och = false;
            }
        }

        public void showPlane()
        {
            Console.WriteLine("Текущая плоскость: " + this.A + "x+" + this.B + "y+" + this.C + "z+" + this.D + "=0");
        }

        public string ratio_of_planes(Planeq P)
        {
            Planeq Q = this;
            string s = "";
            double r = Q.A * P.A + Q.B * P.B + Q.C * P.C;
            if (r == 0)
            {
                s = "Плоскости перпендикулярны";
            }
            else
            {
                double e1 = Q.A * Q.A + Q.B * Q.B + Q.C * Q.C;
                double e2 = P.A * P.A + P.B * P.B + P.C * P.C;
                double cosp = r / Math.Sqrt(e1 * e2);
                if (cosp == 1)
                {
                    s = "Плоскости параллельны";
                }
                else
                {
                    string n = (Math.Acos(cosp) * 180 / Math.PI).ToString();
                    s = "Плоскости пересекаются под углом в " + n + " градусов";
                }
            }
            return s;
        }

        public string insect_line_plane(double x, double y, double z, double a, double b, double c)
        {
            double t1 = this.A * x + this.B * y + this.C * z + this.D;
            double t2 = this.A * a + this.B * b + this.C * c;
            if (t2 == 0) 
            {
                if(t1 == 0)
                {
                    return "Прямая лежит в плоскости";
                }
                return "Прямая и плоскость параллельны"; 
            }
            double t = -t1 / t2;
            x += t * a;
            y += t * b;
            z += t * c;
            string s = "Точка пересечения плоскостей: (" + x + "," + y + "," + z + ")";
            return s;
        }
    }
}
