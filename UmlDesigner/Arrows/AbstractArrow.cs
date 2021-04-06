﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BtnProj.Arrows
{
    public abstract class AbstractArrow
    {
        protected Pen _pen;
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public abstract void Draw(Graphics graphics);

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
    }
}