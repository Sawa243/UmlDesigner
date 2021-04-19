
﻿using System;
using System.Collections.Generic;
using System.Drawing;
 using System.Drawing.Drawing2D;
 using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDesigner.Figure.Action
{
    public class Drawing:IAction
    {
        public void Draw(Graphics graphics, Pen pen, List<Point> points)
        {
            graphics.DrawLines(pen, points.ToArray());
        }

        public void Fill(Graphics graphics, SolidBrush brush, GraphicsPath path)
        {
            graphics.FillPath(brush, path);
        }
    }
}
