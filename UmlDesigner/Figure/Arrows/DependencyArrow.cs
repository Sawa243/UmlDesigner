﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Figure.Arrows
{
    public class DependencyArrow : AbstractArrow
    {
        public DependencyArrow(Pen pen, IAction action)
        {
            _action = action;
            _pen = pen;
            _pen.CustomEndCap = new AdjustableArrowCap(6, 6, false);
            _pen.DashPattern = new float[] { 3f, 2f };

        }
    }
}