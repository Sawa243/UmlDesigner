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
    public abstract class AbstractArrow
    {
        protected IAction _action;
        protected Pen _pen;
        public AbstractArrow()
        {
            _action = new Drawing();
        }

        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        protected List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            points.Add(StartPoint);
            int middleX = (EndPoint.X + StartPoint.X) / 2;
            points.Add(new Point(middleX, StartPoint.Y));
            points.Add(new Point(middleX, EndPoint.Y));
            points.Add(EndPoint);
            return points;
        }
        public void Draw(Graphics graphics)
        {
            _action.Draw(graphics, _pen, GetPoints());
        }
    }
}
