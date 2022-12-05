using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsWork
{
    internal class PointRemember
    {
        private List<Point> PointList = new List<Point> { };
        public PointRemember(){}
        public void DrawCircle(int Xc, int Yc, int Radius)
        {
            int x=0, y=0;
            for (int grad = 0; grad < 360; grad += 1)
            {
                x = (int)(Radius * Math.Cos(grad) + Xc);
                y = (int)(Radius * Math.Sin(grad) + Yc);
                PointList.Add(new Point(x,y));
            }
        }
        public void DrawLine(int X1, int Y1, int X2, int Y2) //Bresenham
        {
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
                PointList.Add(new Point(j, i));
            }
        }
        public List<Point> GetPointList()
        {
            return PointList;
        }
    }
}
