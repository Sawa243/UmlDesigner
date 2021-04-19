using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Figure.Arrows
{
    class InheritanceArrow: AbstractArrow
    {
        public InheritanceArrow(Pen pen, IAction action)
        {
            _action = action;
            _pen = pen;
            _pen.CustomEndCap = GetCustomLineCup();
        }
        private CustomLineCap GetCustomLineCup()
        {
            GraphicsPath hPath = new GraphicsPath();
            PointF[] points = new PointF[]
            {
                new PointF(0, 3),
                new PointF(2, 0),
                new PointF(-2, 0),
                new PointF(0, 3)
            };
            hPath.AddLines(points);
            CustomLineCap compositeCup = new CustomLineCap(null, hPath);
            return compositeCup;
        }
    }
}
