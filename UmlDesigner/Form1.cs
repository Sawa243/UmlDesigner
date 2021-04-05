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
        private bool Flag;
        private Point _firstPoint;
        private Point _lastPoint;

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
            if (Flag)
            {
                //for (int i = 0; i < 10; i++)
                //{
                //    for (int j = 0; j < 10; j++)
                //    {
                //        if (pictureBox1.Width > i + e.X && pictureBox1.Height > j + e.Y)
                //        {
                //            bitmap.SetPixel(i + e.X, j + e.Y, Color.Red);
                //        }
                //    }
                //}

                graphics.Clear(pictureBox1.BackColor);

                _lastPoint = e.Location;

                DrawArrow(graphics, _firstPoint, _lastPoint, Color.Black, 4, 8);

                pictureBox1.Image = bitmap;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Flag = true;
            _firstPoint = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
           Flag = false;
        }

        private void Angle(object sender, MouseEventArgs e)
        {
            pen = new Pen(Color.Blue, 6);
            graphics = Graphics.FromImage(bitmap);
            graphics.DrawLine(pen, 1, 1, 20, 20);
            graphics.DrawLine(pen, 20, 20, 1, 40);
        }

        private void AddLine()
        {
            int x1;
            int x2;
            int y1;
            int y2;

            pen = new Pen(Color.Blue, 6);
            graphics = Graphics.FromImage(bitmap);
            graphics.DrawLine(pen, 1, 1, 20, 20);
        }

        private void DrawArrow(Graphics g, PointF arrowStart, PointF arrowEnd, Color arrowColor, int lineWidth, int arrowMultiplier)
        {
            //create the pen
            Pen p = new Pen(arrowColor, lineWidth);

            //draw the line
            g.DrawLine(p, arrowStart, arrowEnd);

            //determine arrow length
            double arrowLength = Math.Sqrt(Math.Pow(Math.Abs(arrowStart.X - arrowEnd.X), 2) +
                                           Math.Pow(Math.Abs(arrowStart.Y - arrowEnd.Y), 2));

            //determine arrow angle
            double arrowAngle = Math.Atan2(Math.Abs(arrowStart.Y - arrowEnd.Y), Math.Abs(arrowStart.X - arrowEnd.X));

            double pointX, pointY;

            //get the secondary angle of the left tip
            double angleB = Math.Atan2((3 * arrowMultiplier), (arrowLength - (3 * arrowMultiplier)));

            double angleC = Math.PI * (90 - (arrowAngle * (180 / Math.PI)) - (angleB * (180 / Math.PI))) / 180;

            //get the secondary length
            double secondaryLength = (3 * arrowMultiplier) / Math.Sin(angleB);

            if (arrowStart.X > arrowEnd.X)
            {
                pointX = arrowStart.X - (Math.Sin(angleC) * secondaryLength);
            }
            else
            {
                pointX = (Math.Sin(angleC) * secondaryLength) + arrowStart.X;
            }

            if (arrowStart.Y > arrowEnd.Y)
            {
                pointY = arrowStart.Y - (Math.Cos(angleC) * secondaryLength);
            }
            else
            {
                pointY = (Math.Cos(angleC) * secondaryLength) + arrowStart.Y;
            }

            //get the left point
            PointF arrowPointLeft = new PointF((float)pointX, (float)pointY);

            //move to the right point
            angleC = arrowAngle - angleB;

            if (arrowStart.X > arrowEnd.X)
            {
                pointX = arrowStart.X - (Math.Cos(angleC) * secondaryLength);
            }
            else
            {
                pointX = (Math.Cos(angleC) * secondaryLength) + arrowStart.X;
            }

            if (arrowStart.Y > arrowEnd.Y)
            {
                pointY = arrowStart.Y - (Math.Sin(angleC) * secondaryLength);
            }
            else
            {
                pointY = (Math.Sin(angleC) * secondaryLength) + arrowStart.Y;
            }

            PointF arrowPointRight = new PointF((float)pointX, (float)pointY);

            //create the point list
            PointF[] arrowPoints = new PointF[2];
            arrowPoints[0] = arrowPointLeft;
            arrowPoints[1] = arrowPointRight;

            g.DrawLine(p, _lastPoint.X, _lastPoint.Y, arrowPointLeft.X, arrowPointLeft.Y);
            g.DrawLine(p, _lastPoint.X, _lastPoint.Y, arrowPointRight.X, arrowPointRight.Y);
        }
    }
}
