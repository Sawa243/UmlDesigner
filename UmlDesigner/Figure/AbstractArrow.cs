using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using UmlDesigner.Figure.Action;
using UmlDesigner.Figure.Arrows;

namespace UmlDesigner.Figure
{
    public class AbstractArrow : AbstractAllFigurs
    {
        public AbstractArrow()
        {
            _action = new Drawing();
            FigureType figureType = FigureType.Arrow;
        }

        protected override List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            points.Add(StartPoint);
            int middleX = (EndPoint.X + StartPoint.X) / 2;
            points.Add(new Point(middleX, StartPoint.Y));
            points.Add(new Point(middleX, EndPoint.Y));
            points.Add(EndPoint);
            return points;
        }
        public override void Draw(Graphics graphics)
        {
            _action.Draw(graphics, _pen, GetPoints());
        }

        public override CustomLineCap GetCustomLineCap(GraphicsPath HPath)
        {
               CustomLineCap compositeCup = _iCap.GetCustomLineCap(HPath);
            return compositeCup;
        }
    }
}
