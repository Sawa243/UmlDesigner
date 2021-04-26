using System.Drawing;
using System.Drawing.Drawing2D;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Figure.Arrows
{
    class CompositionArrow:AbstractArrow
    {
        public CompositionArrow(Pen pen, IAction action)
        {
            _action = action;
            _pen = pen;
            _pen.CustomEndCap = GetCustomLineCap();
            
        }
        private CustomLineCap GetCustomLineCap()
        {
            GraphicsPath hPath = new GraphicsPath();
            PointF[] points = new PointF[]
            {
                new PointF(0, -1),
                new PointF(2, 2),
                new PointF(0, 5),
                new PointF(-2, 2),
                new PointF(0, -1)
            };
            hPath.AddLines(points);
            CustomLineCap compositeCup = new CustomLineCap( hPath, null);
            return compositeCup;
        }

    }
}
