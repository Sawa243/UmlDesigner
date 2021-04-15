using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UmlDesigner.Fabric;
using UmlDesigner.Figure;


namespace UmlDesigner
{
    public partial class Form1 : Form
    {
        Bitmap _mainBitmap;
        Bitmap _tmpBitmap;
        public Graphics _graphics;
        List<Point> points = new List<Point>();
        IFabric _fabric = new AssotiationFabric();
        private AbstractArrow _crntAbstractArrow;
        Pen pen = new Pen(Color.Black, 3);
        private List<AbstractArrow> arrows = new List<AbstractArrow>();
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


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _IsClicked = true;
            _crntAbstractArrow = _fabric.GetArrow(pen);
            _crntAbstractArrow.StartPoint = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
           _IsClicked = false;
           _mainBitmap = _tmpBitmap;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _tmpBitmap = (Bitmap) _mainBitmap.Clone();
            _graphics = Graphics.FromImage(_tmpBitmap);

            if (_IsClicked)
            {
                _crntAbstractArrow.EndPoint = e.Location;
                _crntAbstractArrow.Draw(_graphics);
            }
            pictureBox1.Image = _tmpBitmap;
        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            EditSizeAndColor();
          
        }
        private void EditSizeAndColor ()
        {
            pen = new Pen(colorDialog1.Color, trackBarSize.Value); 
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            EditSizeAndColor();
        }
    }
}
