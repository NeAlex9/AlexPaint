using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace AlexPaint
{
    public class Polyline : Figure
    {
        public Point[] ArrPoints { get; set; }

        public Polyline()
        {
        }

        public override void Draw(Graphics g, MouseEventArgs e, Pen myPen, int xStart, int yStart)
        {
        }
        
        public override void LeftMouseDownClick(int xClick, int yClick, Bitmap originalCanvas)
        {
            
        }
        
        public override void LeftMouseUpClick(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen, int xPrevClick, int yPrevClick)
        {
            
        }

        public override void RightMouseUpClick(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen)
        {

        }

        public override void FinishPainting(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen)
        {

        }
    }
}