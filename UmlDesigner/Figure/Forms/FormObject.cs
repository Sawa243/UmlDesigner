using System.Drawing;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Figure.Forms
{
    class FormObject : AbstractObjects
    {
        public FormObject()
        {

        }
        public FormObject(Pen pen, IAction action)
        {
            _action = action;
            _pen = pen;
            Color = _pen.Color;
            Width = _pen.Width;
        }
        public override void Draw(Graphics graphics)
        {
            _nameForm = "Object";
            _action.Draw(graphics, _pen, GetPoints());
            Font font = new Font(_nameForm, 23);
            RectangleF Name = new RectangleF(EndPoint.X + 5, EndPoint.Y + 5, 150, 200);
            graphics.DrawString(_nameForm, font, _pen.Brush, Name);
            StartPoint = new Point(EndPoint.X + 150, EndPoint.Y + 200);
        }
    }
}