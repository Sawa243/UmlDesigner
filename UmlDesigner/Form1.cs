using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UmlDesigner.Arrows;

namespace UmlDesigner
{
    public partial class Form1 : Form
    {
        Bitmap _mainBitmap;
        Bitmap _tmpBitmap;
        Graphics _graphics;
        Pen _pen;
        AbstractArrow _crntArrow;
        private Point crntPoint;
        private List<IDrawable> drow = new List<IDrawable>(); 

        bool _IsClicked = false;

        string act = "Inheritance";
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
            string act = "Association";
        }


        //private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    _IsClicked = true;
        //    if(_crntArrow != null) 
        //    { 
        //        _crntArrow.StartPoint = e.Location;
        //        _crntArrow.EndPoint = e.Location;
        //    }
        //}

        //private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        //{
        //   _IsClicked = false;
        //    if(_crntArrow != null)
        //    {
        //        _crntArrow.EndPoint = e.Location;
        //    }
        //    _mainBitmap = _tmpBitmap;
        //}

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Pen pen;
            pen = new Pen(Color.Black);
            //Graphics _graphics;
            _graphics = Graphics.FromImage(_mainBitmap);

            if (e.Button == MouseButtons.Left)
            {
                
                switch (act)
                {
                    case "Rectangle":
                        // отрисовываем оригинальную картинку поверх картинки которой с белым фоном.
                        _graphics.Clear(Color.White);
                        FormClass temp = new FormClass(crntPoint.X, crntPoint.Y, (e.X - crntPoint.X), (e.Y - crntPoint.Y));
                        temp.Draw(_graphics, pen);
                        //_graphics.DrawRectangle(pen, crntPoint.X, crntPoint.Y, (e.X - crntPoint.X), (e.Y - crntPoint.Y));
                        break;
                    case "Connection":
                        _graphics.Clear(Color.White);
                        FillArrow(pen, _graphics, crntPoint.X, crntPoint.Y, e.X, e.Y);
                        break;
                    case "Inheritance":
                        _graphics.Clear(Color.White);
                        ClearArrow(pen, _graphics, crntPoint.X, crntPoint.Y, e.X, e.Y, false);
                        break;
                    case "Realization":
                        _graphics.Clear(Color.White);
                        ClearArrow(pen, _graphics, crntPoint.X, crntPoint.Y, e.X, e.Y, true);
                        break;
                    case "Association":
                        _graphics.Clear(Color.White);
                        ClearArrow(pen, _graphics, crntPoint.X, crntPoint.Y, e.X, e.Y, false, false);
                        break;
                    case "Composition":
                        _graphics.Clear(Color.White);
                        DrawArrowCubeAnchor(pen, _graphics, crntPoint.X, crntPoint.Y, e.X, e.Y);
                        break;
                    case "Aggregation":
                        _graphics.Clear(Color.White);
                        DrawArrowCubeAnchor(pen, _graphics, crntPoint.X, crntPoint.Y, e.X, e.Y, false, false);
                        break;
                }

                _graphics.DrawImage(_mainBitmap, 0, 0);

                pictureBox1.Image = _mainBitmap;
            }

            // ƒл¤ сохранени¤ предыдущих координат.
            crntPoint.X = e.X;
            crntPoint.X = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Pen pen;
            pen = new Pen(Color.Black);
            Graphics graf;
            graf = Graphics.FromImage(_mainBitmap);

            switch (act)
            {
                case "Rectangle":
                    // отрисовываем оригинальную картинку поверх картинки которой с белым фоном.
                    FormClass temp = new FormClass(crntPoint.X, crntPoint.Y, (e.X - crntPoint.X), (e.Y - crntPoint.Y));
                    temp.Draw(graf, pen);
                    drow.Add(temp);
                    //_graphics.DrawRectangle(pen, crntPoint.X, crntPoint.Y, (e.X - crntPoint.X), (e.Y - crntPoint.Y));
                    break;
                case "Connection":
                    FillArrow(pen, graf, crntPoint.X, crntPoint.Y, e.X, e.Y);
                    break;
                case "Inheritance":
                    ClearArrow(pen, graf, crntPoint.X, crntPoint.Y, e.X, e.Y, false);
                    break;
                case "Realization":
                    ClearArrow(pen, graf, crntPoint.X, crntPoint.Y, e.X, e.Y, true);
                    break;
                case "Association":
                    ClearArrow(pen, graf, crntPoint.X, crntPoint.Y, e.X, e.Y, false, false);
                    break;
                case "Composition":
                    DrawArrowCubeAnchor(pen, graf, crntPoint.X, crntPoint.Y, e.X, e.Y);
                    break;
                case "Aggregation":
                    DrawArrowCubeAnchor(pen, graf, crntPoint.X, crntPoint.Y, e.X, e.Y, false, false);
                    break;
            }
        }

        private void FillArrow(Pen pen, Graphics graphics, int x1, int y1, int x2, int y2)
        {
            int width = 15;
            int height = 12;

            pen.CustomEndCap = new AdjustableArrowCap(width, height);
            graphics.DrawLine(pen, x1, y1, x2, y2);
        }

        private void ClearArrow(Pen pen, Graphics graphics, double x1, double y1, double x2, double y2, bool isDash = false, bool isTriangleAnchor = true)
        {
            int width = 15;
            int height = 24;
            if (isDash == true)
            {
                float[] dashPattern = new float[2] { 5f, 5f };
                pen.DashPattern = dashPattern;
            }

            double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            double X = x2 - x1;
            double Y = y2 - y1;

            double X3 = x2 - (X / d) * height;
            double Y3 = y2 - (Y / d) * height;

            double Xp = y2 - y1;
            double Yp = x1 - x2;

            double X4 = X3 + (Xp / d) * width;
            double Y4 = Y3 + (Yp / d) * width;
            double X5 = X3 - (Xp / d) * width;
            double Y5 = Y3 - (Yp / d) * width;
            int X1 = Convert.ToInt32(x1);
            int Y1 = Convert.ToInt32(y1);
            int X2 = Convert.ToInt32(x2);
            int Y2 = Convert.ToInt32(y2);
            if (isTriangleAnchor == true)
            {
                X2 = Convert.ToInt32(X3);
                Y2 = Convert.ToInt32(Y3);
            }
            graphics.DrawLine(pen, X1, Y1, X2, Y2);
            pen.DashStyle = DashStyle.Solid;

            X1 = Convert.ToInt32(x2);// - (X / d) * 10
            Y1 = Convert.ToInt32(y2);// - (X / d) * 10
            X2 = Convert.ToInt32(X4);
            Y2 = Convert.ToInt32(Y4);
            graphics.DrawLine(pen, X1, Y1, X2, Y2);
            int xl = X2;
            int yl = Y2;

            X1 = Convert.ToInt32(x2);// - (X / d) * 10
            Y1 = Convert.ToInt32(y2);// - (X / d) * 10
            X2 = Convert.ToInt32(X5);
            Y2 = Convert.ToInt32(Y5);
            graphics.DrawLine(pen, X1, Y1, X2, Y2);
            if (isTriangleAnchor == true)
            {
                graphics.DrawLine(pen, xl, yl, X2, Y2);
            }
        }

        private void DrawArrowCubeAnchor(Pen pen, Graphics graphics, double x1, double y1, double x2, double y2, bool isDash = false, bool fill = true)
        {
            int width = 15;
            int height = 24;
            if (isDash == true)
            {
                float[] dashPattern = new float[2] { 5f, 5f };
                pen.DashPattern = dashPattern;
            }

            double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            double X = x2 - x1;
            double Y = y2 - y1;

            double X3 = x2 - (X / d) * height;
            double Y3 = y2 - (Y / d) * height;

            double Xp = y2 - y1;
            double Yp = x1 - x2;

            double X4 = X3 + (Xp / d) * width;
            double Y4 = Y3 + (Yp / d) * width;
            double X5 = X3 - (Xp / d) * width;
            double Y5 = Y3 - (Yp / d) * width;
            double X6 = x2 - (X / d) * height * 2;
            double Y6 = y2 - (Y / d) * height * 2;
            int X1 = Convert.ToInt32(x1);
            int Y1 = Convert.ToInt32(y1);
            int X2 = Convert.ToInt32(x2);
            int Y2 = Convert.ToInt32(y2);
            if (fill == false)
            {
                X2 = Convert.ToInt32(X6);
                Y2 = Convert.ToInt32(Y6);
            }
            graphics.DrawLine(pen, X1, Y1, X2, Y2);
            pen.DashStyle = DashStyle.Solid;

            SolidBrush blackBrush = new SolidBrush(Color.Black);

            // Create points that define polygon.
            Point point1 = new Point(Convert.ToInt32(x2), Convert.ToInt32(y2));
            Point point2 = new Point(Convert.ToInt32(X4), Convert.ToInt32(Y4));
            Point point3 = new Point(Convert.ToInt32(X6), Convert.ToInt32(Y6));
            Point point4 = new Point(Convert.ToInt32(X5), Convert.ToInt32(Y5));
            Point[] curvePoints = { point1, point2, point3, point4 };
            if (fill == true)
            {
                // Draw polygon to screen.
                graphics.FillPolygon(blackBrush, curvePoints);
            }
            else
            {
                graphics.DrawPolygon(pen, curvePoints);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            crntPoint = e.Location;
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            act = "Rectangle";
        }

        private void buttonRealization_Click(object sender, EventArgs e)
        {
            act = "Realization";
        }

        private void buttonAssociation_Click(object sender, EventArgs e)
        {
            act = "Association";
        }

        private void buttonComposition_Click(object sender, EventArgs e)
        {
            act = "Composition";
        }

        private void buttonAggregation_Click(object sender, EventArgs e)
        {
            act = "Aggregation";
        }

        private void buttonConnection_Click(object sender, EventArgs e)
        {
            act = "Connection";
        }

        private void buttonInheritance_Click(object sender, EventArgs e)
        {
            act = "Inheritance";
        }
    }

        //private void buttonLine_Click(object sender, EventArgs e)
        //{
        //_crntArrow = new Line();
        //}

     
        //private void AddLine()
        //{
        //    int x1;
        //    int x2;
        //    int y1;
        //    int y2;

        //    _pen = new Pen(Color.Blue, 6);
        //    _graphics = Graphics.FromImage(_mainBitmap);
        //    _graphics.DrawLine(_pen, 1, 1, 20, 20);
        //}
    }

