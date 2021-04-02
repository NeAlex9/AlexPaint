using BaseFigure;
using System.Drawing;
using System.Windows.Forms;

namespace AlexPaint
{
    public class Line : Figure
    {
        public Line()
        {
        }
        
        public override void Draw(Graphics g, MouseEventArgs e, Pen myPen, int xStart, int yStart)
        {
            g.DrawLine(myPen, xStart, yStart , e.X, e.Y);
        }

        public override void LeftMouseDownClick(int xClick, int yClick, Bitmap originalCanvas)
        {
            xStart = xClick;
            yStart = yClick;
            CanvasWithOriginalFigure = originalCanvas;
        }

        public override void LeftMouseUpClick(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen, int xPrevClick, int yPrevClick)
        {
            g.DrawLine(myPen, xPrevClick, yPrevClick, e.X, e.Y);
            g1.DrawLine(myPen, xPrevClick, yPrevClick, e.X, e.Y);
        }

        public override void RightMouseUpClick(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen)
        {
            
        }

        public override void FinishPainting(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen)
        {

        }
    }
}