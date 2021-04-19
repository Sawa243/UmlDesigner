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
            graphics.DrawRectangle(pen, points[0].X, points[0].Y, (points[1].X - points[0].X), (points[1].Y - points[0].Y));
            int line = (points[0].Y + points[1].Y) / 3;
            graphics.DrawLine(pen, points[0].X, line, points[1].X, line);
        }
    }
}
