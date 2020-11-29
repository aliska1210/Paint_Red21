using System.Drawing;

namespace Paint_Red21.Figures
{
    public class FigureResult
    {
        public Bitmap Image { get; }
        public Point Location { get; }
        public FigureResult(Bitmap image, Point location)
        {
            Image = image;
            Location = location;
        }
    }
}
