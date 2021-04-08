using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDesigner
{
    public class FormClass: IDrawable
    {
        public int X { get; set; }
            public int Y { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public FormClass(int x, int y, int width, int height)
            {
                X = x;
                Y = y;
                Width = width;
                Height = height;
            }
            public FormClass()
            {
                X = 10;
                Y = 10;
                Width = 100;
                Height = 100;
            }
            public void Draw(Graphics graf, Pen pen)
            {
                graf.DrawRectangle(pen, X, Y, Width, Height);
            }
        }
    }
