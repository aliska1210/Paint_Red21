using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_Red21.Figures
{
    public interface IFigures
    {
        FigureResult Draw(Bitmap mainBitmap, Bitmap tmpBitmap, Graphics graphics, Point point, Pen pen, MouseEventArgs e);
    }
}
