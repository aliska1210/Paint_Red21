using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Red21
{
  public partial class Form1 : Form
  {
    Bitmap mainBitmap;
    Bitmap tmpBitmap;
    Image image;
    Graphics graphics;
    Pen pen;
    Point point;
    bool mD;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
      //graphics = Graphics.FromImage(mainBitmap);
      //pen = new Pen(Color.Black, 2);
      //pictureBox1.Image = mainBitmap;
      //point = new Point(0, 0);
      //mD = false;
      mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
      graphics = Graphics.FromImage(mainBitmap);
      pen = new Pen(Color.Black, 12);
    }

    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
      if (mD)
      {
        graphics.DrawLine(pen, point, e.Location);
        point = e.Location;
        pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
        tmpBitmap = (Bitmap)mainBitmap.Clone();
        pictureBox1.Image = mainBitmap;
      }
    }

    private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
      mD = false;
    }
    private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
      point = e.Location;
      mD = true;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Point start = new Point(90, 90);
      Point end = new Point(130, 130);
      CircleCreator circle = new CircleCreator();
      List<Point> dots = circle.CreateFigure(start, end);
      pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
      pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
      for (int i = 0; i < dots.Count - 1; i++)
      {
        graphics.DrawLine(pen, dots[i], dots[i + 1]);
      }
      pictureBox1.Image = mainBitmap;
    }
  }
}

