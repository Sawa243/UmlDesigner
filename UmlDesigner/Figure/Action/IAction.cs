
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDesigner.Figure.Action
{
    public interface IAction
    {
        void Draw(Graphics graphics, Pen pen,List<Point> points);
    }
}
