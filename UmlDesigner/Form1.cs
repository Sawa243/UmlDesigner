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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Flag = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
           Flag = false;
        }
    }
}
