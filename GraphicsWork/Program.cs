using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsWork
{
    internal static class Program
    { 
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            PointRemember points = new PointRemember();
            points.DrawCircle(15, 15, 10);
            points.DrawLine(25, 1, 99, 35);
            points.DrawLine(30, 2, 5, 5);
            
            ConsoleDrawer drawer = new ConsoleDrawer(100, 37, ".", points.GetPointList());
                drawer.Show();
            TextDrawer drawer2 = new TextDrawer(points.GetPointList());
                drawer2.Show();
        }
    }
}
