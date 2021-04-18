using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmlDesigner.Figure.Forms;

namespace UmlDesigner.Figure
{
   public class AbstractObjects
    {
        protected FormClass _form;
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Color Color { get; set; }
        public int PenWidth { get; set; }
        public Point Size { get; set; }
        int Line = 3;
        public void DrawTextLabel(Graphics graphics, Rectangle field, string nameLabel)
        {
            var _brush = Brushes.Red;
            StringFormat _stringFormat = new StringFormat();
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            _stringFormat.Alignment = StringAlignment.Center;
            _stringFormat.LineAlignment = StringAlignment.Center;
            graphics.DrawString(nameLabel, new System.Drawing.Font("Segoe Script", 12, FontStyle.Regular), _brush, field, _stringFormat);
        }
        public void Draw (Graphics graphics )
        {
            _form.DrawClassEntity(Color,PenWidth,graphics,StartPoint,Size,Line);
        }
    }
}
