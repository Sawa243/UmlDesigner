using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmlDesigner.Figure.Action;
using UmlDesigner.Figure.Forms;

namespace UmlDesigner.Figure
{
    public abstract class AbstractObjects : AbstractAllFigurs
    {
        protected string _nameForm;
        public AbstractObjects()
        {
            _action = new DrawForms();
            _figureType = 0;
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

        public override bool IsInclude(Point point)
        {
            int xMax;
            int xMin;
            int yMax;
            int yMin;

            if (StartPoint.X > EndPoint.X)
            {
                xMax = StartPoint.X;
                xMin = EndPoint.X;
            }
            else
            {
                xMin = StartPoint.X;
                xMax = EndPoint.X;
            }

            if (StartPoint.Y > EndPoint.Y)
            {
                yMax = StartPoint.Y;
                yMin = EndPoint.Y;
            }
            else
            {
                yMin = StartPoint.Y;
                yMax = EndPoint.Y;
            }
            if (point.X <= xMax && point.X >= xMin
             && point.Y <= yMax && point.Y >= yMin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
