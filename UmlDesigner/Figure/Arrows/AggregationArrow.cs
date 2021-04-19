using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Figure.Arrows
{
    class AggregationArrow:AbstractArrow
    {
        public AggregationArrow(Pen pen, IAction action)
        {
            _action = action;
            _pen = pen;
            _pen.CustomEndCap = new CustomLineCap(null, GetGraphicsPath());
        }
        private GraphicsPath GetGraphicsPath()
        {
            GraphicsPath hPath = new GraphicsPath();
            hPath.AddLine(new Point(0, 0), new Point(10, 10));
            hPath.AddLine(new Point(10, 10), new Point(0, 20));
            hPath.AddLine(new Point(0, 20), new Point(-10, 10));
            hPath.AddLine(new Point(-10, 10), new Point(0, 0));
            return hPath;
        }
}
}
