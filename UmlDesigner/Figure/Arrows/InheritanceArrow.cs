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
            _pen.CustomEndCap = new CustomLineCap(null, GetGraphicsPath());
        }
        private GraphicsPath GetGraphicsPath()
        {
            GraphicsPath cap = new GraphicsPath();
           
            cap.AddLine(-6, 0, 6, 0);
            cap.AddLine(-6, 0, 0, 6);
            cap.AddLine(0, 6, 6, 0);
            return cap;
        }
    }
}
