using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Figure
{
    class AssotiationArrow: AbstractArrow
    {
        public AssotiationArrow(Pen pen, List<Point> points, IAction action)
        {
            pen = new Pen(Color.Black, 3);
            points = GetPoints();
            _action = action;
        }
    }
}
