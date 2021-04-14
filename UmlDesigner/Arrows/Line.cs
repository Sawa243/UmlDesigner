using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDesigner.Arrows
{
    public class Line : AbstractArrow
    { 
        
        public Line()
        {
            pen = new Pen(Color.Black, 3);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLines(pen, GetPoints().ToArray());
        }
    }
}
