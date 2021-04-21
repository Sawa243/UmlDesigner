using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Figure.Forms
{
    class FormObject : AbstractObjects
    {
        public FormObject(Pen pen, IAction action)
        {
            _action = action;
            _pen = pen;
        }
        public override void Draw(Graphics graphics)
        {
            _nameForm = "Object";
            _action.Draw(graphics, _pen, GetPoints());
            Font font = new Font(_nameForm, 23);
            RectangleF Name = new RectangleF(EndPoint.X + 5, EndPoint.Y + 5, 150, 200);
            graphics.DrawString(_nameForm, font, _pen.Brush, Name);
        }
    }
}