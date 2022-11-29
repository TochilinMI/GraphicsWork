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
            IDrawer drawer = new CoordDrawer();
            drawer.DrawCircle(15, 15, 10);
            drawer.DrawLine(25, 1, 99, 35);
            drawer.DrawLine(30, 2, 5, 5);
            drawer.Show();
        }
    }
}
