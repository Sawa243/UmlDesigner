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
        protected Pen _pen;
        public Point point { get; set; }

        public PaintBrush()
        {
            _pen = new Pen(Color.Red, 44);
        }

        public void Draw(Graphics graphics, Bitmap bitmap)
        {
            bitmap.SetPixel(point.X, point.Y, _pen.Color);
        }

    }
}
