using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            graphics.DrawLine(_pen, EndPoint.X, EndPoint.Y+75, EndPoint.X + 150, EndPoint.Y + 75);
            Font font = new Font(_nameForm, 20);
            RectangleF Name = new RectangleF(EndPoint.X+5, EndPoint.Y+5, 150, 200);
            graphics.DrawString(_nameForm, font, _pen.Brush, Name);
        } 
    }
}
