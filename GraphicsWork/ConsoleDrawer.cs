using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsWork
{
    internal class ConsoleDrawer : IDrawer
    {

        private int X1 = 0, Y1 = 0, X2 = 0, Y2 = 0, w = 0, h = 0;
        private String[,] matrix;
        private String cs = "";
        public ConsoleDrawer(int w, int h, String CHAR)
        {
            this.w = w;
            this.h = h;
            this.matrix = new String[h, w];
            //Наполнение матрицы
            for (int row = 0; row < w; row++) for (int col = 0; col < h; col++) matrix[col, row] = CHAR;
        }


        public void DrawCircle(int Xc, int Yc, int Radius)
        {
            int x, y;
            for (int grad = 0; grad < 360; grad += 1)
            {
                x = (int)(Radius * Math.Cos(grad) + Xc);
                y = (int)(Radius * Math.Sin(grad) + Yc);
                matrix[x, y] = "*";
            }
        }
        public void DrawLine(int X1, int Y1, int X2, int Y2) //Bresenham
        {
            this.X1 = X1;
            this.Y1 = Y1;
            this.X2 = X2;
            this.Y2 = Y2;

            matrix[Y1, X1] = "B";
            matrix[Y2, X2] = "E";

            int step = Math.Max(Math.Abs(X2 - X1), Math.Abs(Y2 - Y1));
            Double dx = ((double)X2 - X1) / step;
            Double dy = ((double)Y2 - Y1) / step;
            Double X = X1 + 0.5;
            Double Y = Y1 + 0.5;
            int i = 0, j = 0;
            for (int el = 1; el < step; el++)
            {
                Y += dy;
                i = (int)Y;
                X += dx;
                j = (int)X;
                matrix[i, j] = "*";
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
