
using System.Collections.Generic;
using System.Drawing;


namespace UmlDesigner.Figure.Action
{
    public class Drawing:IAction
    {
        public void Draw(Graphics graphics, Pen pen, List<Point> points)
        {
            graphics.DrawLines(pen, points.ToArray());
        }
    }
}
