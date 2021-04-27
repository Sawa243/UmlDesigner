using System.Drawing;
using System.Drawing.Drawing2D;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Figure.Arrows
{
    class InheritanceArrow: AbstractArrow
    {
        public InheritanceArrow()
        {
        }
        public InheritanceArrow(Pen pen, IAction action)
        {
            _action = action;
            _pen = pen;
            _pen.CustomEndCap = GetCustomLineCap(HPath);
            Color = _pen.Color;
            Width = _pen.Width;
        }
        public override CustomLineCap GetCustomLineCap(GraphicsPath HPath)
        {
            HPath.AddLines(PointsHPath);
            CustomLineCap compositeCup = new CustomLineCap(null, HPath);
            return compositeCup;
        }
        
    }
}
