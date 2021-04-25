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
        public override bool IsInclude(Point point)
        {
            int delta = 5;

            Point pointHead;
            Point pointNext;

            for (int i = 0; i < GetPoints().Count - 1; i++)
            {
                pointHead = (Point)GetPoints().ToArray().GetValue(i);
                pointNext = (Point)GetPoints().ToArray().GetValue(i + 1);

                if (pointHead.X >= pointNext.X
                && pointHead.Y >= pointNext.Y)
                {
                    if (point.X >= pointNext.X - delta
                    && point.X <= pointHead.X + delta
                    && point.Y >= pointNext.Y - delta
                    && point.Y <= pointHead.Y + delta)
                    {
                        return true;
                    }
                }
                if (pointHead.X >= pointNext.X
                && pointHead.Y <= pointNext.Y)
                {
                    if (point.X >= pointNext.X - delta
                    && point.X <= pointHead.X + delta
                    && point.Y >= pointHead.Y - delta
                    && point.Y <= pointNext.Y + delta)
                    {
                        return true;
                    }
                }
                if (pointHead.X <= pointNext.X
                && pointHead.Y >= pointNext.Y)
                {
                    if (point.X >= pointHead.X - delta
                    && point.X <= pointNext.X + delta
                    && point.Y >= pointNext.Y - delta
                    && point.Y <= pointHead.Y + delta)
                    {
                        return true;
                    }
                }
                if (pointHead.X <= pointNext.X
                && pointHead.Y <= pointNext.Y)
                {
                    if (point.X >= pointHead.X - delta
                    && point.X <= pointNext.X + delta
                    && point.Y >= pointHead.Y - delta
                    && point.Y <= pointNext.Y + delta)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public override void Move(int deltaX, int deltaY)
        {
            StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
            EndPoint = new Point(EndPoint.X + deltaX, EndPoint.Y + deltaY);
        }
    }
}
