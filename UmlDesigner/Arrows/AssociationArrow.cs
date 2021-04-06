using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDesigner.Arrows
{
    public class AssociationArrow : AbstractArrow
    {
        public AssociationArrow()
        {
            _pen = new Pen(Color.Black, 3);
        }

        public override void Draw(Graphics graphics)
        {
            var points = GetPoints();
            Point firstPoint;

            if (points.Count == 4 && Math.Abs(StartPoint.X - EndPoint.X) > 15)
            {
                firstPoint = points[2];
            }
            else
            {
                var tmpPoints = points;
                Point newPoint = new Point(EndPoint.X, points[1].Y);
                tmpPoints[1] = newPoint;

                points = new List<Point>() {tmpPoints[0], tmpPoints[1], EndPoint};
                firstPoint = tmpPoints[1];
            }
            
            //draw the line 
            graphics.DrawLines(_pen, points.ToArray());

            //determine arrow length 
            double arrowLength = Math.Sqrt(Math.Pow(Math.Abs(firstPoint.X - EndPoint.X), 2) +
                                           Math.Pow(Math.Abs(firstPoint.Y - EndPoint.Y), 2));

            //determine arrow angle 
            double arrowAngle = Math.Atan2(Math.Abs(firstPoint.Y - EndPoint.Y), Math.Abs(firstPoint.X - EndPoint.X));

            double pointX, pointY;

            //get the secondary angle of the left tip 
            double angleB = Math.Atan2((3 * 3), (arrowLength - (3 * 3)));

            double angleC = Math.PI * (90 - (arrowAngle * (180 / Math.PI)) - (angleB * (180 / Math.PI))) / 180;

            //get the secondary length 
            double secondaryLength = (3 * 3) / Math.Sin(angleB);

            if (firstPoint.X > EndPoint.X)
            {
                pointX = firstPoint.X - (Math.Sin(angleC) * secondaryLength);
            }
            else
            {
                pointX = (Math.Sin(angleC) * secondaryLength) + firstPoint.X;
            }

            if (firstPoint.Y > EndPoint.Y)
            {
                pointY = firstPoint.Y - (Math.Cos(angleC) * secondaryLength);
            }
            else
            {
                pointY = (Math.Cos(angleC) * secondaryLength) + firstPoint.Y;
            }

            //get the left point 
            PointF arrowPointLeft = new PointF((float)pointX, (float)pointY);

            //move to the right point 
            angleC = arrowAngle - angleB;

            if (firstPoint.X > EndPoint.X)
            {
                pointX = firstPoint.X - (Math.Cos(angleC) * secondaryLength);
            }
            else
            {
                pointX = (Math.Cos(angleC) * secondaryLength) + firstPoint.X;
            }

            if (firstPoint.Y > EndPoint.Y)
            {
                pointY = firstPoint.Y - (Math.Sin(angleC) * secondaryLength);
            }
            else
            {
                pointY = (Math.Sin(angleC) * secondaryLength) + firstPoint.Y;
            }

            PointF arrowPointRight = new PointF((float)pointX, (float)pointY);

            //create the point list 
            PointF[] arrowPoints = new PointF[3];
            arrowPoints[0] = arrowPointLeft;
            arrowPoints[1] = EndPoint;
            arrowPoints[2] = arrowPointRight;
            
            graphics.DrawLines(_pen, arrowPoints);
        }
    }
}
