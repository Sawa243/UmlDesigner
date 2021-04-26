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
        public RealizationArrow(Pen pen, IAction action)
        {
        _action = action;
        _pen = pen;
        _pen.CustomEndCap = GetCustomLineCup();
        _pen.DashPattern = new float[] { 3f, 2f };
        Color = _pen.Color;
        Width = _pen.Width;
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
