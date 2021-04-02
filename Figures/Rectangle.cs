using BaseFigure;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace AlexPaint
{
    public class Rectangle : Figure
    {
        public List<Point> Points { set; get; }
        public Rectangle()
        {
            Points = new List<Point>();
        }

        public override void Draw(Graphics g, MouseEventArgs e, Pen myPen, int xStart, int yStart)
        {
            Points.Clear();
            Points.Add(new Point(xStart, yStart));
            Points.Add(new Point(e.X, yStart));
            Points.Add(new Point(e.X, e.Y));
            Points.Add(new Point(xStart, e.Y)); g.DrawPolygon(myPen, Points.ToArray());

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