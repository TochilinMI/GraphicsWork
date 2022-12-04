using System;
using System.Collections.Generic;
using System.Linq;
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
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
            //IDrawer drawer = new ConsoleDrawer(100, 37, ".");
            PointRemember points= new PointRemember();
            points.DrawCircle(15, 15, 10);
            points.DrawLine(25, 1, 99, 35);
            points.DrawLine(30, 2, 5, 5);
            Console.WriteLine(points.GetPointList()[0]);
            //drawer.Show();
        }
    }
}
