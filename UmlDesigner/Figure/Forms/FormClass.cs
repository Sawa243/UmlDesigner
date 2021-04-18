using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDesigner.Figure.Forms
{
   public class FormClass : AbstractObjects
    {
        public void DrawClassEntity(Color color, float penWidth, Graphics graphics, Point startPoint, Point size, int line = 3)
        {
            Pen _pen = new Pen(color, penWidth);
            int _nameHeight = 50;
            int _fieldsHeight = 30;
            int _otherHeight = size.Y - _nameHeight - _fieldsHeight;

            Rectangle _nameRect = new Rectangle(startPoint.X, startPoint.Y, size.X, _nameHeight);
            Rectangle _fieldsRect = new Rectangle(startPoint.X, startPoint.Y + _nameHeight, size.X, _fieldsHeight);
            Rectangle _otherRect = new Rectangle(startPoint.X, startPoint.Y + _nameHeight + _fieldsHeight, size.X, _otherHeight);
            graphics.DrawRectangle(_pen, _nameRect);
            if (line > 1)
                graphics.DrawRectangle(_pen, _fieldsRect);
            if (line > 2)
                graphics.DrawRectangle(_pen, _otherRect);

            DrawTextLabel(graphics, _nameRect, "NewClass");
        }
    }
}
