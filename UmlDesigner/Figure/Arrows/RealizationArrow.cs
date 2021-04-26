using System.Drawing;
using System.Drawing.Drawing2D;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Figure.Arrows
{
    public class RealizationArrow : AbstractArrow
    {
        public RealizationArrow()
        {
        }
        public override CustomLineCap GetCustomLineCap(GraphicsPath HPath)
        {
            HPath.AddLines(PointsHPath);
            CustomLineCap compositeCup = new CustomLineCap(null, HPath);
            return compositeCup;
        }
        public RealizationArrow(Pen pen, IAction action)
        {
        _action = action;
        _pen = pen;
        _pen.CustomEndCap = GetCustomLineCap(HPath);
        _pen.DashPattern = new float[] { 3f, 2f };
        Color = _pen.Color;
        Width = _pen.Width;
        }
    }
}
