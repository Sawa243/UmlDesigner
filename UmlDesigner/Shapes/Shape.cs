using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDesigner.Shapes
{
    public class Shape
    {
        protected Pen _pen;
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public void Draw(Graphics graphics)
        {
            _pen = new Pen(Color.Green, 5);
            graphics.DrawPolygon(_pen, GetPoints().ToArray());
        }

        protected List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();

            points.Add(StartPoint);
            points.Add(new Point(StartPoint.X, EndPoint.Y));
            points.Add(EndPoint);
            points.Add(new Point(EndPoint.X, StartPoint.Y));

            return points;
        }

    }
}
