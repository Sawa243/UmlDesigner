using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UmlDesigner.Fabric;
using UmlDesigner.Figure;
using System.IO;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace UmlDesigner
{
    public partial class MainForm : Form
    {
        public Graphics graphics;
        private Bitmap _mainBitmap;
        private Bitmap _tmpBitmap;
        private IFactory _factory;
        private bool _IsClicked = false;
        private bool _IsMove = false;
        private Pen _pen = new Pen(Color.Red, 4);
        private AbstractAllFigurs _carentObject;
        private List<AbstractAllFigurs> _allFigurs = new List<AbstractAllFigurs>();
        private Point _pointDelta;


        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(_mainBitmap);
            graphics.Clear(Color.White);
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
                    if (a.IsInclude(e.Location))
                    {
                        _carentObject = a;
                        break;
                    }
                }
                if (_carentObject != null)
                {
                    _allFigurs.Remove(_carentObject);
                    _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    graphics = Graphics.FromImage(_mainBitmap);
                    graphics.Clear(Color.White);

                    foreach (AbstractAllFigurs a in _allFigurs)
                    {
                        a.Draw(graphics);
                        a.TextRedactor(graphics, _pen, a.EndPoint);
                    }
                    pictureBox1.Image = _mainBitmap;
                    _pointDelta = e.Location;
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
            if(!(e.Button == MouseButtons.Right))
            {
            _allFigurs.Add(_carentObject); /*надо фиксить**/
            }
                if(_allFigurs.Count > 0 && e.Location == _carentObject.StartPoint)
                { 
                    _allFigurs.Remove(_carentObject);
                }
            if (_IsMove)
            {
                _IsMove = false;
                buttonMove.Text = "Move: off";
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _tmpBitmap = (Bitmap)_mainBitmap.Clone();
            graphics = Graphics.FromImage(_tmpBitmap);
            if (_IsClicked)
            {
                if (_IsMove && _carentObject != null)
                {
                    _carentObject.Move(e.X - _pointDelta.X, e.Y - _pointDelta.Y);
                    _pointDelta = e.Location;
                    _carentObject.TextRedactor(graphics, _pen, _carentObject.EndPoint);
                    buttonMove.Text = "Move: on";
                }
                else
                {
                    buttonMove.Text = "Move: off";
                    _carentObject.EndPoint = e.Location;
                }
                _carentObject.Draw(graphics);
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
                case 1:
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
            buttonMove.Text = "Move: on";
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            graphics = Graphics.FromImage(_mainBitmap);
            graphics.Clear(Color.White);
            _tmpBitmap = _mainBitmap;
            pictureBox1.Image = _tmpBitmap;
            _allFigurs.Clear();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (_allFigurs.Count > 0)
            {
                _allFigurs.RemoveAt(_allFigurs.Count - 1);
                graphics = Graphics.FromImage(_mainBitmap);
                graphics.Clear(Color.White);
                pictureBox1.Image = _mainBitmap;
                foreach (AbstractAllFigurs a in _allFigurs)
                {
                    a.Draw(graphics);
                    a.TextRedactor(graphics, _pen, a.EndPoint);
                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _carentObject.Text = "";
                foreach (AbstractAllFigurs a in _allFigurs)
                {
                    if (a.IsInclude(e.Location))
                    {
                        _carentObject = a;
                        break;
                    }
                }
                if (_carentObject.EndPoint != new Point(0, 0) && _carentObject.figureType == 0)
                {
                    _carentObject.Text = _carentObject.Text + " " + Microsoft.VisualBasic.Interaction.InputBox("Введите текст:");
                    _carentObject.TextRedactor(graphics, _pen, _carentObject.EndPoint);
                }
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            string serialized = JsonConvert.SerializeObject(_allFigurs, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.Objects,
                    //NullValueHandling = NullValueHandling.Ignore
                });

            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(Convert.ToString(dialog.FileName), false))
                {
                    writer.WriteLine(serialized);
                }
            }
        }
        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }
        private void Download_Click(object sender, EventArgs e)
        {
            string fileContainer = "";
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(Convert.ToString(dialog.FileName)))
                {
                    fileContainer = reader.ReadToEnd();
                }
            }

            List<AbstractAllFigurs> deserialized = JsonConvert.DeserializeObject<List<AbstractAllFigurs>>(fileContainer,
                new JsonSerializerSettings()
                {
                    //NullValueHandling = NullValueHandling.Ignore,
                    TypeNameHandling = TypeNameHandling.Objects,
                });

            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(_mainBitmap);
            graphics.Clear(Color.White);

            foreach (AbstractAllFigurs a in deserialized)
            {
                a.HPath = new GraphicsPath();
                a._pen = new Pen(a.Color, a.Width);
                a.Draw(graphics);
                a.TextRedactor(graphics, _pen, a.EndPoint);
                _allFigurs.Add(a);
            }
            pictureBox1.Image = _mainBitmap;

        }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }
        private void SaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _mainBitmap.Save(dialog.FileName, ImageFormat.Png);
            }
        }
    }
}