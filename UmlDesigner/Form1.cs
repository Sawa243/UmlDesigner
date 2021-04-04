using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace UmlDesigner
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        Pen pen;
        bool IsClicked = false;
        Point point;
        Point point1;
        List<TwoPoints> twoPoints = new List<TwoPoints> { };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;
        }

       private void DrowLine (object sender, MouseEventArgs e)
        {
            if (IsClicked)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (pictureBox1.Width > i + e.X && pictureBox1.Height > j + e.Y)
                        {
                            bitmap.SetPixel(i + e.X, j + e.Y, Color.Red);
                        }
                    }
                }
                pictureBox1.Image = bitmap;
            }
        }

        private void button_Connection(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            IsClicked = true;
            point = e.Location;

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
           IsClicked = false;
            twoPoints.Add(new TwoPoints(new Point(point.X,point.Y), new Point(point1.X, point1.Y)));
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked)
            {
                point1 = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            buttonConnection_Paint(sender, e);
        }

        private void buttonConnection_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);

            e.Graphics.DrawLine(pen, new Point(point.X, point.Y), new Point(point1.X, point1.Y));
            foreach(var p in twoPoints)
            {
                e.Graphics.DrawLine(pen, p.X, p.Y);
            }
        }
    }
}
