using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsWork
{
    internal class DrawerGraphics : IDrawer
    {
        private List<Point> PointList;
        private Form1 form = new Form1 { };
        public DrawerGraphics(List<System.Drawing.Point> PointsListNew)
        {
            this.PointList = PointsListNew;
        }
        public void Show()
        {
            foreach (var point in PointList)
            {
                form.drawAnyPoint(point);
            }
        }
    }
}
