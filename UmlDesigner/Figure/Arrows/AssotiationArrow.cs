
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Figure
{
    class AssotiationArrow: AbstractArrow
    {
        public AssotiationArrow(Pen pen, IAction action)
        {
            _action = action;
            _pen = pen;
            _pen.CustomEndCap = new AdjustableArrowCap(6, 6, false);
        }
        //protected override List<Point> GetPoints()
        //{
        //    List<Point> points = new List<Point>();
        //    points.Add(StartPoint);
        //    int middleX = (EndPoint.X + StartPoint.X) / 2;
        //    points.Add(new Point(middleX, StartPoint.Y));
        //    points.Add(new Point(middleX, EndPoint.Y));
        //    points.Add(EndPoint);
        //    return points;
        //}
    }
}
