using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_Red21.Figures
{
    public class PencilFigures : IFigures
    {
        public FigureResult Draw(Bitmap mainBitmap, Bitmap tmpBitmap, Graphics graphics, Point point, Pen pen, MouseEventArgs e)
        {
            graphics = Graphics.FromImage(mainBitmap);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            graphics.DrawLine(pen, point.X, point.Y, e.X, e.Y);
            tmpBitmap = (Bitmap)mainBitmap.Clone();
            return new FigureResult(tmpBitmap, e.Location);
        }
    }
}
