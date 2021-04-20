using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UmlDesigner.Fabric;
using UmlDesigner.Figure;
using UmlDesigner.Figure.Arrows;


namespace UmlDesigner
{
    public partial class Form1 : Form
    {
        Bitmap _mainBitmap;
        Bitmap _tmpBitmap;
        public Graphics _graphics;
        Pen _pen = new Pen(Color.Red,4);
        List<Point> points = new List<Point>();
        IFabric _fabric;
        private AbstractAllFigurs _carentObject;
        private List<AbstractAllFigurs> objects = new List<AbstractAllFigurs>();
        //private List<AbstractObjects> objectForm = new List<AbstractObjects>();
        //private List<AbstractArrow> arrows = new List<AbstractArrow>();
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
            comboBoxArrows.SelectedIndex = 1;
            _fabric = new AssotiationFabric();
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _IsClicked = true;
            _carentObject = _fabric.GetElement(_pen);
            
                _carentObject.StartPoint = e.Location;
                objects.Add(_carentObject);


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

            if (_IsClicked && _carentObject != null)
            {
                _carentObject.EndPoint = e.Location;
                _carentObject.Draw(_graphics);
            }
            pictureBox1.Image = _tmpBitmap;
        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            EditSizeAndColor();
        }
        private void EditSizeAndColor ()
        {
          _pen = new Pen(colorDialog1.Color, trackBarSize.Value);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            EditSizeAndColor();
        }

        private void comboBoxArrows_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBoxArrows.SelectedIndex)
            {
                case 0: _fabric = new AggregationFactory(); 
                    break;
                case 1: _fabric = new AssotiationFabric();
                    break;
                case 2: _fabric = new CompositionFactory();
                    break;
                case 3: _fabric = new InheritanceFactory();
                    break;
                case 4: _fabric = new RealizationFactory();
                    break;
            }
        }

        private void comboBoxForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxForms.SelectedIndex==0)
            {
                _fabric = new FormsClasFactory();
            }
        }
    }
}
