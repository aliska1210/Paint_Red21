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
    public partial class Red_21 : Form
    {
        Bitmap mainBitmap;
        Bitmap tmpBitmap;
        Graphics graphics;
        Pen pen;
        Point point;
        string mod = "";
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

            }
            if ((e.Button == MouseButtons.Left) && (mod == "NAngle"))
            {

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
