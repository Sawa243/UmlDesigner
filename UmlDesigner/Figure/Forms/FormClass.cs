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
        public FormClass (Pen pen,IAction action)
        {
            _action = action;
            _pen = pen;
            

        }
        public override void Draw(Graphics graphics)
        { 
            string s = "Class";
            Point Middle = new Point(StartPoint.X, StartPoint.Y);
            Font font = new Font(s,_pen.Width*5);
            Pen pen = new Pen(Color.White, 1);
            graphics.DrawRectangle(_pen, StartPoint.X + 15, StartPoint.Y + 15, (EndPoint.X - StartPoint.X), (EndPoint.Y - StartPoint.Y));
            graphics.DrawRectangle(_pen, StartPoint.X + 30, StartPoint.Y + 30, (EndPoint.X - StartPoint.X), (EndPoint.Y - StartPoint.Y));
            graphics.FillRectangle(pen.Brush, StartPoint.X, StartPoint.Y, (EndPoint.X - StartPoint.X), (EndPoint.Y - StartPoint.Y));
            graphics.DrawString(s, font, _pen.Brush, Middle);
            _action.Draw(graphics, _pen, GetPoints());
            

        }
    }
}
