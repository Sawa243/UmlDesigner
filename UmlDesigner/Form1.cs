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
        Pen _pen = new Pen(Color.Red, 4);
        IFactory _factory;
        private AbstractAllFigurs _carentObject;
        private List<AbstractAllFigurs> _allFigurs = new List<AbstractAllFigurs>();
        bool _IsClicked = false;
        bool _IsMove = false;
        Point pointDelta;

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
            comboBoxArrows.SelectedIndex = 0;
            _factory = new AggregationFactory();
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _IsClicked = true;
            _pen = new Pen(colorDialog1.Color, trackBarSize.Value);
            _carentObject = _factory.GetElement(_pen);

            if (_IsMove)
            {
                foreach (AbstractAllFigurs a in _allFigurs)
                {
                    if (a.IsItMe(e.Location))
                    {
                        _carentObject = a;
                        break;
                    }
                }
                if (_carentObject != null)
                {
                    _allFigurs.Remove(_carentObject);
                    _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    _graphics = Graphics.FromImage(_mainBitmap);
                    _graphics.Clear(Color.White);

                    foreach (AbstractAllFigurs a in _allFigurs)
                    {
                        a.Draw(_graphics);
                    }
                    pictureBox1.Image = _mainBitmap;
                    pointDelta = e.Location;
                }
            }
            else
            {
                if (_carentObject != null)
                {
                    _carentObject.StartPoint = e.Location;
                }
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _IsClicked = false;
            _mainBitmap = _tmpBitmap;
            _allFigurs.Add(_carentObject);
            if (_IsMove)
            { _IsMove = false;
              buttonMove.Text = "Move:of";
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _tmpBitmap = (Bitmap)_mainBitmap.Clone();
            _graphics = Graphics.FromImage(_tmpBitmap);
            if (_IsClicked)
            {
                if (_IsMove && _carentObject != null)
                {
                    _carentObject.Move(e.X - pointDelta.X, e.Y - pointDelta.Y);
                    pointDelta = e.Location;
                    buttonMove.Text = "Move:on";
                }
                else
                {
                    buttonMove.Text = "Move:of";
                    _carentObject.EndPoint = e.Location;
                }
                _carentObject.Draw(_graphics);
            }
            pictureBox1.Image = _tmpBitmap;
            GC.Collect();
        }
        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            EditSizeAndColor();
        }
        private void EditSizeAndColor()
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
                case 0:
                    _factory = new AggregationFactory();
                    break;
                case 1:
                    _factory = new AssotiationFactory();
                    break;
                case 2:
                    _factory = new CompositionFactory();
                    break;
                case 3:
                    _factory = new InheritanceFactory();
                    break;
                case 4:
                    _factory = new RealizationFactory();
                    break;
            }
        }
        private void comboBoxForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxForms.SelectedIndex)
            {
                case 1 :
                _factory = new FormsClasFactory();
            break;
                case 0:
                    _factory = new FormBlockFactory();
                    break;
                case 2:
                    _factory = new FormInterfaceFactory();
                    break;
                case 3:
                    _factory = new FormObjectFactory();
                    break;
            }
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            _carentObject = null;
            _IsMove = true;
            buttonMove.Text = "Move:on";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            _tmpBitmap = _mainBitmap;
            pictureBox1.Image = _tmpBitmap;
            _allFigurs.Clear();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            _allFigurs.RemoveAt(_allFigurs.Count - 1);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;
            foreach (AbstractAllFigurs a in _allFigurs)
            {
                a.Draw(_graphics);
            }
        }
    }
}
