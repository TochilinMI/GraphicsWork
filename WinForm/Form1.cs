using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Point> items = new List<Point>();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            items.Add(e.Location);
            Refresh();
        }

        private void drawitem(Graphics g, int x, int y)
        {
            int r = 10;
            g.DrawRectangle(Pens.BurlyWood, x - r, y - r, r + r, r + r);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var p in items)
                drawitem(e.Graphics, p.X, p.Y);
        }
    }
}
