using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint_Red21.Figures
{
    class NAngleFigure
    {
        public FigureResult Draw(Bitmap mainBitmap, Bitmap tmpBitmap, Graphics graphics, Point point, Pen pen, MouseEventArgs e)
        {
            graphics = Graphics.FromImage(mainBitmap);
            graphics.Clear(Color.White);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            double radius = Math.Sqrt(Math.Pow(e.Y - point.Y, 2) + Math.Pow(e.X - point.X, 2));
            Point[] points = new Point[8]; // 8 - количество точек
            for (int i = 0; i < 8; i++)
            {
                points[i] = new Point(Convert.ToInt32(point.X + radius * Math.Cos((2 * Math.PI * i) / 8)),
                                      Convert.ToInt32(point.Y + radius * Math.Sin((2 * Math.PI * i) / 8)));
            }
            graphics.DrawPolygon(pen, points);
            tmpBitmap = (Bitmap)mainBitmap.Clone();
            return new FigureResult(tmpBitmap, e.Location);
        }
    }
}
