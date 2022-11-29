using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsWork
{
    internal interface IDrawer
    {
        void DrawLine(int X1, int Y1, int X2, int Y2);
        void DrawCircle(int Xc, int Yc, int Radius);
        void Show();
    }
}
