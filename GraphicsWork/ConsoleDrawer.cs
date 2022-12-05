using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsWork
{
    internal class ConsoleDrawer
    {

        private int w = 0, h = 0;
        private List<Point> PointList;
        private String[,] matrix;
        private String cs = "";
        public ConsoleDrawer(int w, int h, String CHAR, List<System.Drawing.Point> PointsListNew)
        {
            this.w = w;
            this.h = h;
            this.PointList = PointsListNew;
            this.matrix = new String[h, w];
            //Наполнение матрицы
            for (int row = 0; row < w; row++) for (int col = 0; col < h; col++) matrix[col, row] = CHAR;
            foreach (var point in PointList)
            {
                //Console.WriteLine(point.X+","+point.Y);
                matrix[point.Y, point.X] = "*";
            }
        }
        public void Show()
        {
            // Отрисовка матрицы
            for (int row = 0; row < h; row++)
            {
                for (int col = 0; col < w; col++) cs += matrix[row, col];
                Console.WriteLine(cs);
                cs = "";
            }
        }

    }
}
