using System.Collections.Generic;
using System.Drawing;
using UmlDesigner.Figure.Action;
using System.Drawing.Drawing2D;


namespace UmlDesigner.Figure
{
    public abstract class AbstractObjects : AbstractAllFigurs
    {
        protected string _nameForm;
        public AbstractObjects()
        {
            _action = new DrawForms();
            FigureType figureType = FigureType.Element;
        }
        protected override List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            points.Add(StartPoint);
            points.Add(EndPoint);
            return points;
        }
        public override void Draw(Graphics graphics)
        {
            _action.Draw(graphics, _pen, GetPoints());
        }
        public override CustomLineCap GetCustomLineCap(GraphicsPath HPath)
        {
            throw new System.NotImplementedException();
        }
    }
}
