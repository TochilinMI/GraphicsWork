using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
        }
        /*private void Form1_Paint(object sender, PaintEventArgs e)
        {   
            //Console.WriteLine(sender);
            //g = e.Graphics;
            //g.Clear(Color.White);
            //g.DrawLine(Pens.Black, new Point(1,2), new Point(100, 20));
            //g.DrawLine(Pens.Black, new Point(1, 2), new Point(100, 20));
        }*/
        public void drawAnyPoint(Point point)
        {
            Graphics g = Graphics.FromHwnd(Handle);
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, point, point);
        }
    }
}
