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

        public override void OnMouseDownClick(int xClick, int yClick)
        {
            xStart = xClick;
            yStart = yClick;
        }

        public override void OnMouseUpClick(Graphics g, MouseEventArgs e, Pen myPen, int xClick, int yClick)
        {
            g.DrawLine(myPen, xClick, yClick, e.X, e.Y);
        }
    }
}