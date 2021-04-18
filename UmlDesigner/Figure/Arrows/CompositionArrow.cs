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
    public class CompositionArrow : AbstractArrow
    {
        public CompositionArrow(Pen pen, IAction action)
        {
            action = action;
            _pen = pen;
            _pen.EndCap = LineCap.DiamondAnchor;

        }
    }
}
