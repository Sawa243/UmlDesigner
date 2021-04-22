using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Figure
{
    public class AbstractArrow : AbstractAllFigurs
    {
        public AbstractArrow()
        {
            _action = new Drawing();
            _figureType = 1;
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
        public override bool IsItMe(Point point)
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
        public override void Move(int deltaX, int deltaY)
        {
            StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
            EndPoint = new Point(EndPoint.X + deltaX, EndPoint.Y + deltaY);
        }
    }
}
