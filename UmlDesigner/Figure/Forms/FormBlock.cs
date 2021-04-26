using System.Drawing;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Figure.Forms
{
    class FormBlock : AbstractObjects
    {
        public FormBlock()
        {
        }
        public FormBlock(Pen pen, IAction action)
        {
            _action = action;
            _pen = pen;
            Color = _pen.Color;
            Width = _pen.Width;
        }
        public override void Draw(Graphics graphics)
        {
            _action.Draw(graphics, _pen, GetPoints());
            StartPoint = new Point(EndPoint.X + 150, EndPoint.Y + 200);
        }
    }
}
