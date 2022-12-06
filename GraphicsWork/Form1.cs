using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsWork
{
    public partial class Form1 : Form
    {
        List<Point> items = new List<Point>();
        public Form1()
        {
            InitializeComponent();
            PointRemember points = new PointRemember();
            points.DrawCircle(150, 150, 100);
            points.DrawLine(250, 10, 990, 350);
            points.DrawLine(300, 20, 50, 50);
            items = points.GetPointList();

            /*  //отрисовка в консоле
                DrawerConsole drawer = new DrawerConsole(1000, 370, ".", points.GetPointList());
                drawer.Show();
                DrawerText drawer2 = new DrawerText(points.GetPointList());
                drawer2.Show();*/
        }
        
        private void drawItem(Graphics g, int x, int y)
        {
            g.DrawLine(Pens.BurlyWood, x, y, x+1,y+1);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var p in items)
                drawItem(e.Graphics, p.X, p.Y);
        }
    }
}
