using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UmlDesigner.Fabric;
using UmlDesigner.Figure;


namespace UmlDesigner
{
    public partial class Form1 : Form
    {
        Bitmap _mainBitmap;
        Bitmap _tmpBitmap;
        Graphics _graphics;
        Pen _pen;

        private List<AbstractArrow> arrows = new List<AbstractArrow>();

        //private IFabric _fabric = new AssotiationFabric();
        //AbstractArrow _crntArrow;

        bool _IsClicked = false;

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

       //private void DrowBrush (object sender, MouseEventArgs e)
       // {
       //     if (_IsClicked)
       //     {
       //         for (int i = 0; i < 10; i++)
       //         {
       //             for (int j = 0; j < 10; j++)
       //             {
       //                 if (pictureBox1.Width > i + e.X && pictureBox1.Height > j + e.Y)
       //                 {
       //                     _mainBitmap.SetPixel(i + e.X, j + e.Y, Color.Red);
       //                 }
       //             }
       //         }
       //         pictureBox1.Image = _mainBitmap;
       //     }
       // }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _IsClicked = true;
            //if(_crntArrow != null) 
            //{ 
            //    _crntArrow.StartPoint = e.Location;
            //    _crntArrow.EndPoint = e.Location;
            //}
            List<Point> points = new List<Point>();
                points.Add(new Point(e.X));
                points.Add(new Point(e.Y));
            
            IFabric _fabric = new AssotiationFabric();

            arrows.Add(_fabric.GetArrow(_pen, points));
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
           _IsClicked = false;
            //if(_crntArrow != null)
            //{
            //    _crntArrow.EndPoint = e.Location;
            //}
            _mainBitmap = _tmpBitmap;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (_IsClicked&&
            //    (_crntArrow != null))
            //{
            //    _tmpBitmap = (Bitmap)_mainBitmap.Clone();
            //    _graphics = Graphics.FromImage(_tmpBitmap);

            //    _crntArrow.EndPoint = e.Location;

            //    _crntArrow.Draw(_graphics);

            //    pictureBox1.Image = _tmpBitmap;
            //    GC.Collect();
            //}
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            //_crntArrow = new Line();
            //GetArrow(pen, points);
            

        }

        private void Angle(object sender, MouseEventArgs e)
        {
            _pen = new Pen(Color.Blue, 6);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.DrawLine(_pen, 1, 1, 20, 20);
            _graphics.DrawLine(_pen, 20, 20, 1, 40);
        }

        private void AddLine()
        {
            int x1;
            int x2;
            int y1;
            int y2;

            _pen = new Pen(Color.Blue, 6);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.DrawLine(_pen, 1, 1, 20, 20);
        }
    }
}
