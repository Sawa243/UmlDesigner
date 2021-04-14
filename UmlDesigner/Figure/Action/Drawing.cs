using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDesigner.Figure.Action
{
    public class Drawing:IAction
    {
        //private Pen pen;
        //private List<Point> points;
        private Graphics graphics;

        public void Draw(Pen pen, List<Point> points)
        {
            graphics.DrawLines(pen, points.ToArray());
        }
    }
}
