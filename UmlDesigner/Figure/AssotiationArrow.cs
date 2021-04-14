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
        //Pen pen = new Pen(Color.Black, 3);
        public AssotiationArrow(Pen pen, IAction action)
        {
            List<Point> points = GetPoints();

            _action = action;
        }
    }
}
