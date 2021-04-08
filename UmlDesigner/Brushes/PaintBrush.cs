using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDesigner
{
    public class PaintBrush
    {
        public Pen pen;
        public Point point { get; set; }

        public PaintBrush()
        {
            pen = new Pen(Color.Red, 6);
        }

        public void Draw(Graphics graphics, Bitmap bitmap)
        {
            bitmap.SetPixel(point.X, point.Y, pen.Color);
        }

    }
}
