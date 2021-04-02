using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace AlexPaint
{
    public class Brush : Figure
    {
        public override void Draw(Graphics g, MouseEventArgs e, Pen myPen, int xStart, int yStart)
        {
            g.DrawLine(myPen, xStart, yStart, e.X, e.Y);
        }
        
        public override void LeftMouseDownClick(int xClick, int yClick, Bitmap originalCanvas)
        {
            xStart = xClick;
            yStart = yClick;
            CanvasWithOriginalFigure = originalCanvas;
        }
        
        public override void LeftMouseUpClick(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen, int xPrevClick, int yPrevClick)
        {
            
        }

        public override void RightMouseUpClick(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen)
        {
            g1 = g;

        }

        public override void FinishPainting(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen)
        {
            
        }
    }
}