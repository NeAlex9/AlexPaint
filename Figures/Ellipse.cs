using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace AlexPaint
{
    public class Ellipse : Figure
    {
        List<Point> Points { set; get; }
        public Ellipse()
        {
            Points = new List<Point>();
        }

        public override void Draw(Graphics g, MouseEventArgs e, Pen myPen, int xStart, int yStart)
        {
            Points.Clear();
            Points.Add(new Point(xStart, yStart));
            Points.Add(new Point(e.X, yStart));
            Points.Add(new Point(e.X, e.Y));
            Points.Add(new Point(xStart, e.Y));
            if (xStart <= e.X && yStart <= e.Y)
            {
                g.DrawEllipse(myPen, xStart, yStart, e.X - xStart, e.Y - yStart);
            }
            else if (xStart > e.X && yStart <= e.Y)
            {
                g.DrawEllipse(myPen, e.X, yStart, xStart - e.X, e.Y - yStart);
            }
            else if ((xStart <= e.X && yStart > e.Y))
            {
                g.DrawEllipse(myPen, xStart, e.Y, e.X - xStart, yStart - e.Y);
            }
            else if (xStart > e.X && yStart > e.Y)
            {
                g.DrawEllipse(myPen, e.X, e.Y, xStart - e.X, yStart - e.Y);
            }
        }
        
        public override void LeftMouseDownClick(int xClick, int yClick, Bitmap originalCanvas)
        {
            xStart = xClick;
            yStart = yClick;
            CanvasWithOriginalFigure = originalCanvas;
        }
        
        public override void LeftMouseUpClick(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen, int xPrevClick, int yPrevClick)
        {
            Draw(g, e, myPen, xPrevClick, yPrevClick);
            Draw(g1, e, myPen, xPrevClick, yPrevClick);
        }

        public override void RightMouseUpClick(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen)
        {

        }

        public override void FinishPainting(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen)
        {

        }
    }
}