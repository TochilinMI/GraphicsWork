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

        private int X1 = 0, Y1 = 0, X2 = 0, Y2 = 0, w = 0, h = 0;
        private String[,] matrix;
        private String cs = "";
        public ConsoleDrawer(int w, int h, String CHAR,List<Point> PointsList)
        {
            this.w = w;
            this.h = h;
            this.matrix = new String[h, w];
            //Наполнение матрицы
            for (int row = 0; row < w; row++) for (int col = 0; col < h; col++) matrix[col, row] = CHAR;
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
