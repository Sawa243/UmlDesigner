
using System.Collections.Generic;
using System.Drawing;
using UmlDesigner.Figure.Action;
using UmlDesigner.Figure.Forms;

namespace UmlDesigner.Figure
{
    public abstract class AbstractAllFigurs : ITextInForm
    {
        protected IAction _action;
        protected Pen _pen;
        public int _figureType;
        public string Text { get; set; }
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public AbstractAllFigurs()
        {
            _action = new Drawing();
        }
        protected abstract List<Point> GetPoints();
        public abstract void Draw(Graphics graphics);
        public bool IsInclude(Point point)
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
        public void Move(int deltaX, int deltaY)
        {
            StartPoint = new Point(StartPoint.X + deltaX, StartPoint.Y + deltaY);
            EndPoint = new Point(EndPoint.X + deltaX, EndPoint.Y + deltaY);
        }
        public void TextRedactor(Graphics graphics, Pen pen, Point EndPoint)
        {
            Font font = new Font(Text, 23);
            RectangleF PlaceToWrite = new RectangleF(EndPoint.X + 5, EndPoint.Y + 55, 140, 140);
            graphics.DrawString(Text, font, pen.Brush, PlaceToWrite);
        }
    }
}
