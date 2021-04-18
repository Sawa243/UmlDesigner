using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDesigner.Figure.Action
{
   public class DrawForms :IAction
    {
        public void Draw(Graphics graphics, Pen pen, List<Point> points)
        {

            int Wight = points[2].X;
            int Height = points[3].X;
            int x = points[0].X;
            int y = points[0].Y;
            graphics.DrawRectangle(pen, x, y, Height, Wight);

        }
    }
}
