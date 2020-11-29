using System;
using System.Drawing;
using System.Windows.Forms;
using Paint_Red21.Figures;

namespace Paint_Red21
{
    public partial class Red_21 : Form
    {
        Bitmap mainBitmap;
        Bitmap tmpBitmap;
        Graphics graphics;
        Pen pen;
        Point point;
        string mod = "";
        PencilFigure figure = new PencilFigure();
        NAngleFigure figureNAngle = new NAngleFigure();
        public Red_21()
        {
            InitializeComponent();
        }
        private void Red_21_Load(object sender, EventArgs e)
        {
            mainBitmap = new Bitmap(paintSurface.Width, paintSurface.Height);
            graphics = Graphics.FromImage(mainBitmap);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pen = new Pen(Color.Red, 1);
            paintSurface.Image = mainBitmap;
            point = new Point(0, 0);
        }

        private void paintSurface_MouseMove(object sender, MouseEventArgs e)
        {
            if((e.Button == MouseButtons.Left) && (mod == "pencil"))
            {
                FigureResult result = figure.Draw(mainBitmap, tmpBitmap, graphics, point, pen, e);
                paintSurface.Image = result.Image;
                point = result.Location;
            }
            if ((e.Button == MouseButtons.Left) && (mod == "NAngle"))
            {
                FigureResult resultNAngle = figureNAngle.Draw(mainBitmap, tmpBitmap, graphics, point, pen, e);
                paintSurface.Image = resultNAngle.Image;
            }
        }

        private void paintSurface_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
        }

        private void paintSurface_MouseUp(object sender, MouseEventArgs e)
        {
            point = e.Location;
        }

        private void Pencil_Click(object sender, EventArgs e)
        {
            mod = "pencil";
        }

        private void NAngle_Click(object sender, EventArgs e)
        {
            mod = "NAngle";
        }
    }
}
