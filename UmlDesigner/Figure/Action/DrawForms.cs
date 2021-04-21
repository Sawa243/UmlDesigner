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
            graphics.DrawRectangle(pen, points[1].X, points[1].Y, 150, 200);
            int line = (points[1].Y +50);
            graphics.DrawLine(pen, points[1].X, line, points[1].X+150, line);
        }
    }
}
