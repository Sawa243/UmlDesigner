﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UmlDesigner.Arrows;
using UmlDesigner.Shapes;

namespace UmlDesigner
{
    public partial class Form1 : Form
    {
        Bitmap _mainBitmap;
        Bitmap _tmpBitmap;
        Graphics _graphics;
        Pen _pen;
        AbstractArrow _crntArrow;
        PaintBrush _brush;
        Shape _shape;

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
            if(_crntArrow != null) 
            { 
                _crntArrow.StartPoint = e.Location;
                _crntArrow.EndPoint = e.Location;
            }
            if (_shape != null)
            {
                _shape.StartPoint = e.Location;
                _shape.EndPoint = e.Location;
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
           _IsClicked = false;
            if(_crntArrow != null)
            {
                _crntArrow.EndPoint = e.Location;
            }
            if (_shape != null)
            {
                _shape.EndPoint = e.Location;
            }

            _mainBitmap = _tmpBitmap;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _tmpBitmap = (Bitmap)_mainBitmap.Clone();
            _graphics = Graphics.FromImage(_tmpBitmap);

            if (_IsClicked&&
                (_crntArrow != null))
            {
                _crntArrow.EndPoint = e.Location;
                _crntArrow.Draw(_graphics);
            }
            if (_IsClicked &&
              (_brush != null))
            {
                _brush.point = e.Location;
                _brush.Draw(_graphics, _mainBitmap);
            }
            if(_IsClicked &&
                (_shape != null))
            {
                _shape.EndPoint = e.Location;
                _shape.Draw(_graphics);
            }

            pictureBox1.Image = _tmpBitmap;
            GC.Collect();
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            _crntArrow = new Line();
            _brush = null;
            _shape = null;
        }

        private void buttonBrush_Click(object sender, EventArgs e)
        {
            _brush = new PaintBrush();
            _crntArrow = null;
            _shape = null;
        }

        private void buttonShape_Click(object sender, EventArgs e)
        {
            _shape = new Shape();
            _crntArrow = null;
            _brush = null;
        }
    }
}
