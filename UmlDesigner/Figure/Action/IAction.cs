
using System.Collections.Generic;
using System.Drawing;


namespace UmlDesigner.Figure.Action
{
    public interface IAction
    {
        void Draw(Graphics graphics, Pen pen,List<Point> points);
    }
}
