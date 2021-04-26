
using System.Drawing;
using System.Drawing.Drawing2D;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Figure
{
    class AssotiationArrow: AbstractArrow
    {
        public AssotiationArrow()
        {

        }
        public AssotiationArrow(Pen pen, IAction action)
        {
            _action = action;
            _pen = pen;
            _pen.CustomEndCap = new AdjustableArrowCap(5, 5);
            Color = _pen.Color;
            Width = _pen.Width;
        }
    }
}
