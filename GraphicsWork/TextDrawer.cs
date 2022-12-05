using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsWork
{
    internal class TextDrawer
    {
        private List<Point> PointList;
        public TextDrawer(List<Point> PointsListNew){
            this.PointList = PointsListNew;
        }
        public void Show()
        {
            Console.WriteLine("Список точек для отрисовки");
            // Отрисовка матрицы
            foreach (var point in PointList)
            {
                Console.WriteLine($"t({point.Y},{point.X})");
            }
        }

    }
}
