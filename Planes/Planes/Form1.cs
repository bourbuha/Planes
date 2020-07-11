using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plane;
using System.Globalization;

namespace Planes
{
    public partial class Form1 : Form
    {
        Planeq N;
        public Form1()
        {
            InitializeComponent();
            N = new Planeq();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NA.Text != "" && NB.Text != "" && NC.Text != "" && ND.Text != "" )
            {
                double a = double.Parse(NA.Text, CultureInfo.InvariantCulture.NumberFormat);
                double b = double.Parse(NB.Text, CultureInfo.InvariantCulture.NumberFormat);
                double c = double.Parse(NC.Text, CultureInfo.InvariantCulture.NumberFormat);
                double d = double.Parse(ND.Text, CultureInfo.InvariantCulture.NumberFormat);
                N = new Planeq(a, b, c, d);
                label1.Text = "Текущая плоскость: " + a + "x+" + b + "y+" + c + "z+" + d + "=0";
            }
            else
            {
                Answer.Text = "Ошибка ввода";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (N.och == false)
            {
                if (PA.Text != "" && PB.Text != "" && PC.Text != "" && PD.Text != "")
                {
                    double a = double.Parse(PA.Text, CultureInfo.InvariantCulture.NumberFormat);
                    double b = double.Parse(PB.Text, CultureInfo.InvariantCulture.NumberFormat);
                    double c = double.Parse(PC.Text, CultureInfo.InvariantCulture.NumberFormat);
                    double d = double.Parse(PD.Text, CultureInfo.InvariantCulture.NumberFormat);
                    Planeq P = new Planeq(a, b, c, d);
                    string s = N.ratio_of_planes(P);
                    Answer.Text = s;
                }
                else
                {
                    Answer.Text = "Ошибка ввода";
                }
            }
            else
            {
                Answer.Text = "Не задана текущая плоскость";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (N.och == false)
            {
                if (da.Text != "" && db.Text != "" && dc.Text != "" && ba.Text != "" && bb.Text != "" && bc.Text != "")
                {
                    double x = double.Parse(da.Text, CultureInfo.InvariantCulture.NumberFormat);
                    double y = double.Parse(db.Text, CultureInfo.InvariantCulture.NumberFormat);
                    double z = double.Parse(dc.Text, CultureInfo.InvariantCulture.NumberFormat);
                    double a = double.Parse(ba.Text, CultureInfo.InvariantCulture.NumberFormat);
                    double b = double.Parse(bb.Text, CultureInfo.InvariantCulture.NumberFormat);
                    double c = double.Parse(bc.Text, CultureInfo.InvariantCulture.NumberFormat);
                    string s = N.insect_line_plane(x, y, z, a, b, c);
                    Answer.Text = s;
                }
                else
                {
                    Answer.Text = "Ошибка ввода";
                }
            }
            else
            {
                Answer.Text = "Не задана текущая плоскость";
            }
        }
    }
}
