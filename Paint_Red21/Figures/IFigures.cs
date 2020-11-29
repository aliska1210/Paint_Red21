using System.Drawing;
using System.Windows.Forms;

namespace Paint_Red21.Figures
{
    public interface IFigures
    {
        FigureResult Draw(Bitmap mainBitmap, Bitmap tmpBitmap, Graphics graphics, Point point, Pen pen, MouseEventArgs e);
    }
}
