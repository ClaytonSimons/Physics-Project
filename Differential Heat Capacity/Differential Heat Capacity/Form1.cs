using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Differential_Heat_Capacity
{
    public partial class Form1 : Form
    {
        Point[] pts;
        int count = 0;
        double Kb = 1.38 * Math.Pow(10, -23),// J/K
            h = 1.055 * Math.Pow(10,-34),// Js
            v = 3500;// m/s
        double T = 100000;
        Graphics G;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GraphBtn_Click(object sender, EventArgs e)
        {
            
            double w = 0; // frequency
            int steps = 500;
            pts = new Point[steps];
            double T = Convert.ToDouble(TkUD.Value) * Math.Pow(10, 3);
            for (int i = 1; i < steps+1; i++ )
            {
                w = i * 3.8 * (int)Math.Pow(10, 11)*T;
                double x = h*w/(Kb*T);
                double u = 3*Kb/(2*Math.Pow(Math.PI,2)*Math.Pow(v,3)) * Math.Pow(Kb/h,3)*Math.Pow(T,3) * (Math.Pow(x,4)*Math.Exp(x))/Math.Pow((Math.Exp(x)-1),2);// C(w)
                u = u / (1*Math.Pow(10,Convert.ToDouble(scalerUD.Value)));
                pts[i-1] = new Point(i, canvasePicBox.Height - Convert.ToInt32(Math.Truncate(u)));
            }
            Bitmap bit = new Bitmap(canvasePicBox.Width,canvasePicBox.Height);
            G = Graphics.FromImage(bit);
            canvasePicBox.Image = bit;
            G.DrawLines(new Pen(Brushes.Black, 1), pts);
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            double w = 0; // frequency
            int steps = 500;
            pts = new Point[steps];
            double T = Convert.ToDouble(TkUD.Value) * Math.Pow(10, 3);
            for (int i = 1; i < steps+1; i++)
            {
                w = i * 3.8 * (int)Math.Pow(10, 11) * T;
                double x = h * w / (Kb * T);
                double u = 3 * Kb / (2 * Math.Pow(Math.PI, 2) * Math.Pow(v, 3)) * Math.Pow(Kb / h, 3) * Math.Pow(T, 3) * (Math.Pow(x, 4) * Math.Exp(x)) / Math.Pow((Math.Exp(x) - 1), 2);// C(w)
                u = u / (1 * Math.Pow(10, Convert.ToDouble(scalerUD.Value)));
                pts[i - 1] = new Point(i, canvasePicBox.Height - Convert.ToInt32(Math.Truncate(u)));
            }
            G.DrawLines(new Pen(Brushes.Blue, 1), pts);
        }
    }
}
