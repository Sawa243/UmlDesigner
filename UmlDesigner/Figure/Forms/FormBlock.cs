using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmlDesigner.Figure.Action;

namespace UmlDesigner.Figure.Forms
{
    class FormBlock : AbstractObjects
    {
        public FormBlock(Pen pen, IAction action)
        {
            _action = action;
            _pen = pen;
        }
        public override void Draw(Graphics graphics)
        {
            _action.Draw(graphics, _pen, GetPoints());
            StartPoint = new Point(EndPoint.X + 150, EndPoint.Y + 200);
        }
    }
}
