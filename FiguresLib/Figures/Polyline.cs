using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace Polyline
{
    public class Polyline : Figure
    {
        public Point[] ArrPoints { get; set; }

        public Polyline(Color color, int width) : base(color, width)
        {
        }

        public override void Draw(PaintEventArgs e)
        {
        }

        public override void Clear(PaintEventArgs e)
        {
        }

    }
}