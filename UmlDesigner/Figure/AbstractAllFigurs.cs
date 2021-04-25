using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UmlDesigner.Figure.Action;
using System.ComponentModel;
using System.Data;
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
        public abstract bool IsInclude(Point point);
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
