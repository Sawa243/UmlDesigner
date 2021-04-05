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
        Bitmap _mainBitmap;
        Bitmap _tmpBitmap;
        Graphics _graphics;
        Pen _pen;
        Point _point;
        Point _point1;
        //double Angle = 1.3;
        bool _IsClicked = false;
        string actual = "";
        List<TwoPoints> twoPoints = new List<TwoPoints> { };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;
        }

       private void DrowBrush (object sender, MouseEventArgs e)
        {
            if (_IsClicked)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (pictureBox1.Width > i + e.X && pictureBox1.Height > j + e.Y)
                        {
                            _mainBitmap.SetPixel(i + e.X, j + e.Y, Color.Red);
                        }
                    }
                }
                pictureBox1.Image = _mainBitmap;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _IsClicked = true;
            _point = e.Location;

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
           _IsClicked = false;
            twoPoints.Add(new TwoPoints(new Point(_point.X,_point.Y), new Point(_point1.X, _point1.Y)));
            _mainBitmap = _tmpBitmap;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_IsClicked)
            {
                _point1 = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (actual == "Lines")
            {
                DrowLines_Paint(sender, e);
            }
        }

        private void DrowLines_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);

            //double vect = Math.Atan2(point.X - point1.X, point.Y - point1.Y);

            e.Graphics.DrawLine(pen, new Point(_point.X, _point.Y), new Point(_point1.X, _point1.Y));
            //e.Graphics.DrawLine(pen, new Point(point.X, point.Y), new Point(Convert.ToInt32(point1.X + 10 * Math.Sin(0.2 + vect)), (Convert.ToInt32(point1.X + 10 * Math.Cos(0.2 + vect))));
            foreach (var p in twoPoints)
            {
                e.Graphics.DrawLine(pen, p.X, p.Y);
            }
        }

        private void buttonConnection_Click(object sender, EventArgs e)
        {
            actual = "Lines";
        }
    }
}
