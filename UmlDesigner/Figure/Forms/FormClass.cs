using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Figure.Forms
{
   public class FormClass : AbstractObjects
    {
        public FormClass()
        {

        }
        public FormClass (Pen pen,IAction action)
        {
            _action = action;
            _pen = pen;
            Color = _pen.Color;
            Width = _pen.Width;
        }
        public override void Draw(Graphics graphics)
        {
            _nameForm = "Class";
            Pen pen = new Pen(Color.White, 1);
            graphics.DrawRectangle(_pen, EndPoint.X + 15, EndPoint.Y + 15, 150,200);  
            graphics.DrawRectangle(_pen, EndPoint.X + 30, EndPoint.Y + 30, 150, 200);
            graphics.FillRectangle(pen.Brush, EndPoint.X + 15, EndPoint.Y + 15, 150, 200);
            graphics.FillRectangle(pen.Brush, EndPoint.X, EndPoint.Y, 150, 200);
            _action.Draw(graphics, _pen, GetPoints());
            Font font = new Font(_nameForm, 23);
            RectangleF Name = new RectangleF(EndPoint.X+5, EndPoint.Y+5, 150, 200);
            graphics.DrawString(_nameForm, font, _pen.Brush, Name);
        }
    }
}
