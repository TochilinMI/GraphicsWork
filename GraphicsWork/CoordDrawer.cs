using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsWork
{
    internal class CoordDrawer : IDrawer
    {
        private List<string> PointList = new List<string>{"Список точек"};
        public CoordDrawer(){}
        public void DrawCircle(int Xc, int Yc, int Radius)
        {
            int x=0, y=0;
            for (int grad = 0; grad < 360; grad += 1)
            {
                x = (int)(Radius * Math.Cos(grad) + Xc);
                y = (int)(Radius * Math.Sin(grad) + Yc);
                if (grad == 0) PointList.Add($"()Begin circle({x},{y})");
                PointList.Add($"Point({x},{y})");
            }
            PointList.Add($"()End circle({x},{y})");
        }
        public void DrawLine(int X1, int Y1, int X2, int Y2) //Bresenham
        {
            PointList.Add($"______________Begin line({X1},{Y1})");

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
                PointList.Add($"line({j},{i})");
            }

            PointList.Add($"______________End line({X1},{Y1})");
        }

        public void Show()
        {
            // Отрисовка матрицы
            foreach (var point in PointList)
            {
                Console.WriteLine(point);
            }            
        }

    }
}
