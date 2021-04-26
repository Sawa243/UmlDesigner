using System.Drawing;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Figure.Forms
{
    public class FormInterface : AbstractObjects
    {
        public FormInterface(Pen pen, IAction action)
        {
            _action = action;
            _pen = pen;
        }
        public override void Draw(Graphics graphics)
        {
            _action.Draw(graphics, _pen, GetPoints());
            _nameForm = "Inteface";
            Font font = new Font(_nameForm, 20);
            RectangleF Name = new RectangleF(EndPoint.X+5, EndPoint.Y+5, 150, 200);
            graphics.DrawString(_nameForm, font, _pen.Brush, Name);
            StartPoint = new Point(EndPoint.X + 150, EndPoint.Y + 200);
        } 
    }
}
